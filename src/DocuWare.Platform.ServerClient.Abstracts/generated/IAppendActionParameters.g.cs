using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAppendActionParameters : IDocumentActionParameters
    {
		bool RemoveSourceDocuments { get; set; }
		List<IAppendActionDocuments> DocumentsInFront { get; set; }
		List<IAppendActionDocuments> DocumentsAtBack { get; set; }
    }
}
