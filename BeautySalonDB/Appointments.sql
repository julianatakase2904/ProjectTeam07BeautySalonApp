CREATE TABLE [dbo].[Appointments]
(
	[AppointmentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AppointmentDate] NVARCHAR(50) NOT NULL, 
    [AppointmentTime] NVARCHAR(50) NOT NULL, 
    [ClientId] INT NOT NULL, 
    [EmployeeId] INT NOT NULL, 
    [ServiceId] INT NOT NULL, 
    CONSTRAINT [FK_Appointments_Clients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([ClientId]), 
    CONSTRAINT [FK_Appointments_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([EmployeeId]), 
    CONSTRAINT [FK_Appointments_Services] FOREIGN KEY ([ServiceId]) REFERENCES [Services]([ServiceId])
)
