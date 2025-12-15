using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentVersion
    {
		int Major { get; set; }
		int Minor { get; set; }
    }
}
