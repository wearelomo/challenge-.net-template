CREATE PROCEDURE [dbo].[CreatePerson]
	@param1 int = 0,
	@param2 int
AS BEGIN
	INSERT INTO People([Name], Lastname, Phone) VALUES ('', '', '')
END
