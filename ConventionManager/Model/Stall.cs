using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionManager.Model
{
    public class Stall
    {
        [Key]
        public int StallId { get; set; }
        public string StallName { get; set; }
        public string StallLocationCode { get; set; }
        public int StallCapacity { get; set; }
        public string StallResources { get; set; }
        public DateTime StallStartDate { get; set; }
        public DateTime StallEndDate { get; set; }
        public string StallType { get; set; }
    }
}
