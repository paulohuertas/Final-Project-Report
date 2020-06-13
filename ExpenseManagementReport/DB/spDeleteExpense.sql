CREATE PROCEDURE spDeleteExpense
@ReportId INT,
@ActionType VARCHAR(20)

AS
	BEGIN
	IF @ActionType = 'Delete'
		DELETE FROM tb_Report 
		WHERE ReportId = @ReportId
	END
GO
