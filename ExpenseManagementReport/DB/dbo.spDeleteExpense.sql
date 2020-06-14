CREATE PROCEDURE spDeleteExpense
@ReceiptNo INT,
@FK_UserId INT,
@ActionType VARCHAR(20)

AS
	BEGIN
	IF @ActionType = 'Delete'
		DELETE FROM tb_Report 
		WHERE ReceiptNo = @ReceiptNo AND FK_UserId = @FK_UserId
	END


	DROP PROCEDURE spDeleteExpense