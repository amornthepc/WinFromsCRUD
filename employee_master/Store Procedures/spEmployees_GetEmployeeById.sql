CREATE PROCEDURE [dbo].[spEmployees_GetEmployeeById]
	@Id int
AS
BEGIN
	SELECT [e].[Id], [e].[FirstName], [e].[LastName], [e].[PhoneNumber], [e].[HireDate], [e].[Salary], [e].[Status], [j].[Title] AS JobTitle
	FROM dbo.Employees e
	INNER JOIN dbo.Jobs j
		ON j.Id = e.JobId
	WHERE e.Id = @Id;
END