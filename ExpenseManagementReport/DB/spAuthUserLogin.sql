CREATE PROCEDURE spAuthUserLogin
@Username VARCHAR(50),
@Password VARCHAR(50)

AS
	BEGIN
		SELECT Username, Password FROM tb_User WHERE Username = @Username AND Password = @Password
	END
GO