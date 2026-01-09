using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateDocumentsSource : IBatchUpdateSource
    {
		List<int> Id { get; set; }
    }
}
