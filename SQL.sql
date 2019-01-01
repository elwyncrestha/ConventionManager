create database ConventionManager;
use ConventionManager;

--- Independent tables ---
create table Attendee
(
	AttendeeId int not null identity,
	AttendeeFName varchar(255) not null,
	AttendeeLName varchar(255) not null,
	AttendeeEmail varchar(255) not null,
	AttendeeContact varchar(255) not null,
	AttendeeAddress varchar(255) not null,
	TicketType varchar(255) not null,
	AttendingDays int not null,
	IsAvailable bit not null,
	constraint pk_Attendee primary key (AttendeeId),
	constraint ix_AttendeeEmail unique (AttendeeEmail)
);

create table Room
(
	RoomId int not null identity,
	RoomName varchar(255) not null,
	RoomLocationCode varchar(255) not null,
	RoomCapacity int not null,
	RoomResources varchar(255) not null,
	constraint pk_Room primary key (RoomId),
	constraint ix_RoomName unique (RoomName)
);

create table Stall
(
	StallId int not null identity,
	StallName varchar(255) not null,
	StallLocationCode varchar(255) not null,
	StallCapacity int not null,
	StallResources varchar(255) not null,
	StallStartDate datetime not null,
	StallEndDate datetime not null,
	StallType varchar(255) not null,
	constraint pk_Stall primary key (StallId),
	constraint ix_StallName unique (StallName)
);

--- One key dependent tables ---
create table Event
(
	EventId int not null identity,
	EventName varchar(255) not null,
	EventStartDate datetime not null,
	EventEndDate datetime not null,
	EventDescription varchar(500) not null,
	RoomId int not null,
	constraint pk_Event primary key (EventId),
	constraint fk_Event_Room foreign key (RoomId) references Room (RoomId)
);

create table Seminar
(
	SeminarId int not null identity,
	SeminarName varchar(255) not null,
	SeminarStartDate datetime not null,
	SeminarEndDate datetime not null,
	RoomId int not null,
	constraint pk_Seminar primary key (SeminarId),
	constraint fk_Seminar_Room foreign key (RoomId) references Room (RoomId)
);

--- Two keys dependent tables ---
create table AttendeeStall
(
	---Id int not null identity,
	AttendeeId int not null,
	StallId int not null,
	---constraint pk_AttendeeStall primary key (Id),
	constraint fk_AttendeeStall_Attendee foreign key (AttendeeId) references Attendee(AttendeeId) on delete cascade,
	constraint fk_AttendeeStall_Stall foreign key (StallId) references Stall(StallId),
	constraint pk_AttendeeStall primary key (AttendeeId,StallId)
);

create table AttendeeEvent
(
	---Id int not null identity,
	AttendeeId int not null,
	EventId int not null,
	---constraint pk_AttendeeEvent primary key (Id),
	constraint fk_AttendeeEvent_Attendee foreign key (AttendeeId) references Attendee(AttendeeId) on delete cascade,
	constraint fk_AttendeeEvent_Event foreign key (EventId) references Event(EventId),
	constraint pk_AttendeeEvent primary key (AttendeeId,EventId)
);

create table AttendeeSeminar
(
	---Id int not null identity,
	AttendeeId int not null,
	SeminarId int not null,
	IsPresenter bit,
	---constraint pk_AttendeeSeminar primary key (Id),
	constraint fk_AttendeeSeminar_Attendee foreign key (AttendeeId) references Attendee(AttendeeId) on delete cascade,
	constraint fk_AttendeeSeminar_Event foreign key (SeminarId) references Seminar(SeminarId),
	constraint pk_AttendeeSeminar primary key (AttendeeId,SeminarId)
);

SELECT Distinct TABLE_NAME FROM information_schema.TABLES;

select * from Attendee;
select * from Stall;
select * from Room;
select * from Event;
select * from Seminar;
select * from AttendeeStall;
select * from AttendeeEvent;
select * from AttendeeSeminar;