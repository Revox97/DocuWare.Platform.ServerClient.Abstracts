using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentActionInfo
    {
		IDocumentActionParameters DocumentActionParameters { get; set; }
		DocumentAction DocumentAction { get; set; }
    }
}
