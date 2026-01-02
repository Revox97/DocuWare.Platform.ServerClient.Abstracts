using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAppendActionParameters
    {
		List<IAppendActionDocuments> DocumentsInFront { get; set; }
		List<IAppendActionDocuments> DocumentsAtBack { get; set; }
    }
}
