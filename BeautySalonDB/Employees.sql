CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeFirstName] NVARCHAR(50) NOT NULL, 
    [EmployeeLastName] NVARCHAR(50) NOT NULL
)
