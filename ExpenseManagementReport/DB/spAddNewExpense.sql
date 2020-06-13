CREATE PROCEDURE spAddNewReport
@ExpName VARCHAR(100),
@ExpTotal DECIMAL(18),
@ExpCategory VARCHAR(50),
@ReceiptNo INT,
@ReceiptDate DATE,
@Image VARBINARY(max),
@ActionType VARCHAR(20)
AS
	BEGIN
		IF @ActionType = 'Save'
		BEGIN
			IF NOT EXISTS(SELECT * FROM tb_Report WHERE ReceiptNo = @ReceiptNo)
			BEGIN
			INSERT INTO tb_Report
						(ExpName, ExpTotal, ExpCategory, ReceiptNo, ReceiptDate, Image)
			VALUES
						(@ExpName, @ExpTotal, @ExpCategory, @ReceiptNo, @ReceiptDate, @Image)
			END
		END
	END
GO









/*
public int ReportId { get; set; }
        public string ExpName { get; set; }
        public float ExpTotal { get; set; }
        public string ExpCategory { get; set; }
        public int ReceiptNo { get; set; }
        public DateTime receiptDate { get; set; }
        public string Image { get; set; }

		*/
