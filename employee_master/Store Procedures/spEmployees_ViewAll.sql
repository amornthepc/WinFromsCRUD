CREATE PROCEDURE [dbo].[spEmployees_ViewAll]
AS
BEGIN
	SELECT [e].[FirstName], [e].[LastName], [e].[PhoneNumber], [e].[HireDate], [e].[Salary], [e].[Status], [j].[Title] 
	FROM dbo.Employees e
	INNER JOIN dbo.Jobs j
		ON j.Id = e.JobId
END
