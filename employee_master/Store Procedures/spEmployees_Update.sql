CREATE PROCEDURE [dbo].[spEmployees_Update]
	@Id int,
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


	UPDATE dbo.Employees
	SET FirstName = @FirstName,
		LastName = @LastName,
		PhoneNumber = @PhoneNumber,
		HireDate = @HireDate,
		Salary = @Salary,
		JobId = @JobId,
		Status = @Status
	WHERE Id = @Id

END
