using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public interface IContentAreaPreferences
    {
		List<IWorkInstance> Instances { get; set; }
		WorkAreaType AreaType { get; set; }
		int SelectedInstanceIndex { get; set; }
    }
}
