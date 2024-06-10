CREATE PROCEDURE [dbo].[spEmployees_GetAllOrSearch]
	@SearchText NVARCHAR(50)
AS
BEGIN
	SELECT [e].[Id], [e].[FirstName], [e].[LastName], [e].[PhoneNumber], [e].[HireDate], [e].[Salary], Status = (CASE WHEN e.Status = 0 THEN 'Inactive' ELSE 'Active' END), [j].[Title] AS JobTitle
	FROM dbo.Employees e
	INNER JOIN dbo.Jobs j
		ON j.Id = e.JobId
	WHERE 
		@SearchText = '' OR
		FirstName LIKE '%'+@SearchText+'%';
END
