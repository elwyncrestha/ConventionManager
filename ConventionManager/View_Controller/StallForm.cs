﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConventionManager.Model;

namespace ConventionManager.View_Controller
{
    public partial class StallForm : Form
    {
        ConventionManagerDbContext dbContext = new ConventionManagerDbContext();
        Stall stall;

        public StallForm()
        {
            InitializeComponent();
        }

        private void StallForm_Load(object sender, EventArgs e)
        {
            reloadDGV();
        }

        private void reloadDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StallId", typeof(int));
            dt.Columns.Add("StallName", typeof(string));
            dt.Columns.Add("StallLocationCode", typeof(string));
            dt.Columns.Add("StallCapacity", typeof(int));
            dt.Columns.Add("StallResources", typeof(string));
            dt.Columns.Add("StallStartDate", typeof(DateTime));
            dt.Columns.Add("StallEndDate", typeof(DateTime));
            dt.Columns.Add("StallType", typeof(string));
            dt.Columns.Add("Exhibitors", typeof(string));

            List<Stall> stallList = dbContext.Stalls.ToList();
            foreach(Stall stall in stallList)
            {
                string exhibitors = null;
                List<string> exhibitorList = dbContext.AttendeeStalls.Where(a => a.StallId == stall.StallId).Where(a => a.IsExhibitor==true).Select(a => a.Attendee.AttendeeFName).ToList();
                foreach (string name in exhibitorList)
                    exhibitors += exhibitors != null ? (", " + name) : name;

                // row add
                dt.Rows.Add(stall.StallId, stall.StallName, stall.StallLocationCode, 
                    stall.StallCapacity, stall.StallResources, stall.StallStartDate, 
                    stall.StallEndDate, stall.StallType, exhibitors==null ? "Vacant" : exhibitors);
            }

            dgvStall.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter stall name!!!");
                txtName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtLocationCode.Text))
            {
                MessageBox.Show("Please enter stall location code!!!");
                txtLocationCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtCapacity.Text))
            {
                MessageBox.Show("Please enter stall capacity!!!");
                txtCapacity.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtResources.Text))
            {
                MessageBox.Show("Please enter stall resources!!!");
                txtResources.Focus();
                return;
            }
            else if(DateTime.Compare(dtpStartDate.Value,DateTime.Now) < 0)
            {
                MessageBox.Show("Invalid start date: Date crossed already!!!");
                dtpStartDate.Focus();
                return;
            }
            else if(DateTime.Compare(dtpStartDate.Value,dtpEndDate.Value) >= 0)
            {
                MessageBox.Show("End date must be after start date!!!");
                dtpStartDate.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStallType.Text))
            {
                MessageBox.Show("Please enter stall type!!!");
                txtStallType.Focus();
                return;
            }
            else
            {
                if (btnAdd.Text.Equals("ADD"))
                    stall = new Stall();
                else if (btnAdd.Text.Equals("UPDATE"))
                    stall.StallId = stallCode;

                stall.StallName = txtName.Text.Trim();
                stall.StallLocationCode = txtLocationCode.Text.Trim();
                stall.StallCapacity = Convert.ToInt32(txtCapacity.Text.Trim());
                stall.StallResources = txtResources.Text.Trim();
                stall.StallStartDate = dtpStartDate.Value;
                stall.StallEndDate = dtpEndDate.Value;
                stall.StallType = txtStallType.Text;

                try
                {
                    if (btnAdd.Text.Equals("ADD"))
                        dbContext.Stalls.Add(stall);

                    dbContext.SaveChanges();
                    MessageBox.Show(String.Format("Stall {0} successfully!!!", btnAdd.Text.Equals("ADD") ? "added" : "updated"));
                    btnAdd.Text = "ADD";

                    txtName.Clear();
                    txtLocationCode.Clear();
                    txtCapacity.Clear();
                    txtResources.Clear();
                    dtpStartDate.Text = DateTime.Now.ToString();
                    dtpEndDate.Text = DateTime.Now.ToString();
                    txtStallType.Clear();

                    reloadDGV();
                    txtName.Focus();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int stallCode;
        private void dgvStall_Click(object sender, EventArgs e)
        {
            stallCode = int.Parse(dgvStall.CurrentRow.Cells["StallId"].Value.ToString());
            int columnIndex = dgvStall.CurrentCell.ColumnIndex;

            if (dgvStall.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Edit"))
            {
                btnAdd.Text = "UPDATE";
                stall = dbContext.Stalls.Find(stallCode);
                txtName.Text = stall.StallName;
                txtLocationCode.Text = stall.StallLocationCode;
                txtCapacity.Text = stall.StallCapacity.ToString();
                txtResources.Text = stall.StallResources;
                txtStallType.Text = stall.StallType;
                dtpStartDate.Value = stall.StallStartDate;
                dtpEndDate.Value = stall.StallEndDate;
            }
            else if (dgvStall.CurrentRow.Cells[columnIndex].Value.ToString().Equals("Delete"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // on delete cascade only on AttendeeId in AttendeeStall
                    // first remove data held by foreign key in AttendeeStall
                    var stalls = dbContext.AttendeeStalls.Where(a => a.StallId == stallCode).ToList();
                    foreach (var del in stalls)
                        dbContext.AttendeeStalls.Remove(del);
                    dbContext.SaveChanges();

                    // then remove stall
                    dbContext.Stalls.Remove(dbContext.Stalls.Find(stallCode));
                    dbContext.SaveChanges();
                    reloadDGV();

                    MessageBox.Show("Stall deleted!!!");
                }
                btnAdd.Text = "ADD";
            }
        }

        private void StallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoader.loadHome();
            this.Close();
        }
    }
}
