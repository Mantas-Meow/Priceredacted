﻿CREATE TABLE [dbo].Products
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product] NVARCHAR(50) NOT NULL, 
    [Price] MONEY NULL
)