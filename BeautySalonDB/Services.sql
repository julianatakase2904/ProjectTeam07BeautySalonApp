CREATE TABLE [dbo].[Services]
(
	[ServiceId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ServiceName] NVARCHAR(50) NOT NULL, 
    [ServicePrice] DECIMAL NOT NULL, 
    [ProductId] INT NULL, 
    CONSTRAINT [FK_Services_Inventory] FOREIGN KEY ([ProductId]) REFERENCES [Inventory]([ProductId]) 
)
