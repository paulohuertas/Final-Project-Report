SELECT ReportId, ExpName, ExpTotal, ExpCategory, ReceiptNo, ReceiptDate, Username FROM tb_Report LEFT JOIN tb_User ON UserId = ReportId 
WHERE Username = 'paulo' AND Password = 'paulo';