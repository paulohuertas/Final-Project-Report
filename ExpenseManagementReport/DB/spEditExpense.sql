CREATE PROCEDURE spEditExpense
@ExpName VARCHAR(100),
@ExpTotal DECIMAL(18),
@ExpCategory VARCHAR(50),
@ReceiptNo INT,
@ReceiptDate DATE,
@Image VARBINARY(max),
@ActionType VARCHAR(20)

AS
	BEGIN
		IF @ActionType = 'Edit'
		BEGIN
			UPDATE tb_Report
			SET 
			ExpName = @ExpName, 
			ExpTotal = @ExpTotal, 
			ExpCategory = @ExpCategory,
			ReceiptDate = @ReceiptDate,
			Image = @Image
			WHERE ReceiptNo = @ReceiptNo
		END
	END
GO