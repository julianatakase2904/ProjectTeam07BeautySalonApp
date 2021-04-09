CREATE TABLE [dbo].[Payments]
(
	[PaymentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [AppointmentId] INT NOT NULL, 
    [Tax] DECIMAL NOT NULL, 
    [Paid] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Payments_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([EmployeeId]), 
    CONSTRAINT [FK_Payments_Appointments] FOREIGN KEY ([AppointmentId]) REFERENCES [Appointments]([AppointmentId])
)
