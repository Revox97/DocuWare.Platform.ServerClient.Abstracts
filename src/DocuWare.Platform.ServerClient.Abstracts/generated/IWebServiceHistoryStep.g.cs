using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebServiceHistoryStep
    {
		List<IHistoryField> Parameters { get; set; }
		List<IHistoryField> Results { get; set; }
		string Method { get; set; }
    }
}
