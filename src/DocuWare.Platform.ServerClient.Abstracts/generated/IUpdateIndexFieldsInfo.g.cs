using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUpdateIndexFieldsInfo : IDocumentIndexFields
    {
		string DialogId { get; set; }
		bool NormalizeCoordinates { get; set; }
		bool ForceUpdate { get; set; }
    }
}
