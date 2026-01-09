using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentsTransferInfo
    {
		List<IDocument> Documents { get; set; }
		string SourceFileCabinetId { get; set; }
		bool UseDefaultDialog { get; set; }
		bool KeepSource { get; set; }
		bool FillIntellix { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
