using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIntellixFieldAssignments
    {
		List<IIntellixFieldMapping> Items { get; set; }
		List<IIntellixTableFieldMapping> IntellixTableFieldItems { get; set; }
		string IntellixLanguage { get; set; }
    }
}
