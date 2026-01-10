using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAppendActionDocuments
    {
		string SourceCabinetId { get; set; }
		List<int> Documents { get; set; }
    }
}
