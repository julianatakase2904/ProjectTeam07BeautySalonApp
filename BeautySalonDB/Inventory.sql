CREATE TABLE [dbo].[Inventory]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [ProductQuantity] INT NOT NULL
)
