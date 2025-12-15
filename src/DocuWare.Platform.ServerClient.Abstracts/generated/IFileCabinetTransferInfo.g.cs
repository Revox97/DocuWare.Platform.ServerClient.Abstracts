using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetTransferInfo
    {
		List<int> SourceDocId { get; set; }
		string SourceFileCabinetId { get; set; }
		bool KeepSource { get; set; }
		bool FillIntellix { get; set; }
    }
}
