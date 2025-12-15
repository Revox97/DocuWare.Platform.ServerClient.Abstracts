using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentActionInfo
    {
		IDocumentActionParameters DocumentActionParameters { get; set; }
		DocuWare.Platform.ServerClient.DocumentAction DocumentAction { get; set; }
    }
}
