using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchRestoreDocumentsSource
    {
		List<string> Id { get; set; }
    }
}
