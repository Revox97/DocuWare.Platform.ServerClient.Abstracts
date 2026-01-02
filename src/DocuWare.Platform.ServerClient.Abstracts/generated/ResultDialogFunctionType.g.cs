namespace DocuWare.Platform.ServerClient.Abstracts
{
    public enum ResultDialogFunctionType
    {
		StartNewRetrieval = 0,
		LinkSearch = 1,
		DisplayDocument = 2,
		DisplayInfoBox = 3,
		PrintSelectedDocument = 4,
		DeleteSelectedDocument = 5,
		CopyToBasket = 6,
		Versions = 7,
		AppendFromBasket = 8,
		DownloadAsOriginal = 9,
		DownloadAsPDFWithoutAnno = 10,
		DownloadAsPDFWithAnno = 11,
		SendAsOriginal = 12,
		SendAsPDFWithoutAnno = 13,
		SendAsPDFWithAnno = 14,
		SendAsHyperlink = 15,
		SendResultList = 16,
		EMailReply = 17,
		EMailReplyAll = 18,
		EMailForward = 19,
		ShowInSeparateViewer = 20,
		EditDocument = 21,
		ShowWorkflowHistory = 22,
		ExportToCSV = 23,
		CreateREQUEST = 24,
		ChangeIndexOfMultipleDocuments = 25,
		CheckOutToBasket = 26,
		CheckOutToFileSystem = 27,
		ChangeDocumentStatus = 28,
		ShowVersionHistory = 29,
		CopyIntoAnotherFileCabinet = 30,
		SendREQUEST = 31
    }
}
