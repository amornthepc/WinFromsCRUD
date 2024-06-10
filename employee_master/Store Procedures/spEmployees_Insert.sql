CREATE PROCEDURE [dbo].[spEmployees_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@PhoneNumber nvarchar(20),
	@HireDate date,
	@Salary money,
	@JobTitle nvarchar(100),
	@Status bit
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @JobId int;

	IF NOT EXISTS (SELECT 1 FROM dbo.Jobs WHERE Title = @JobTitle)
	BEGIN
		INSERT INTO dbo.Jobs (Title)
		VALUES (@JobTitle)

		SELECT @JobId = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SELECT @JobId = Id FROM dbo.Jobs WHERE Title = @JobTitle;
	END

	INSERT INTO dbo.Employees (FirstName, LastName, PhoneNumber, HireDate, Salary, Status, JobId)
	VALUES (@FirstName, @LastName, @PhoneNumber, @HireDate, @Salary, @Status, @JobId);
END
