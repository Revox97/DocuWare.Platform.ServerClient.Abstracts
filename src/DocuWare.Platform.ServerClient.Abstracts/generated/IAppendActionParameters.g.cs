using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAppendActionParameters : IDocumentActionParameters
    {
		List<IAppendActionDocuments> DocumentsInFront { get; set; }
		List<IAppendActionDocuments> DocumentsAtBack { get; set; }
    }
}
