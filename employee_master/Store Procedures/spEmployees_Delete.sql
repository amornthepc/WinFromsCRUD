CREATE PROCEDURE [dbo].[spEmployees_Delete]
	@Id int
AS
BEGIN

	DELETE dbo.Employees
	WHERE Id = @Id;
END
