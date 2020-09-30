CREATE PROCEDURE [dbo].[AddData]
	@add nvarchar(50),
	@Id int,
	@Product nvarchar(50), 
	@Price money
AS
	BEGIN
	INSERT INTO Products(Product, Price) VALUES(@Product, @Price)
	END
