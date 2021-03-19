CREATE TABLE [dbo].[Clients]
(
	[ClientId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientFirstName] NVARCHAR(50) NOT NULL, 
    [ClientLastName] NVARCHAR(50) NOT NULL, 
    [ClientPhoneNumber] NVARCHAR(14) NOT NULL
)
