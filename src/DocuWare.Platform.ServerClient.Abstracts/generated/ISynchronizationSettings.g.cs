using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISynchronizationSettings
    {
		string MediaType { get; }
		List<IFieldMapping> FieldMappings { get; set; }
		SynchronizationOperation SynchronizationOperation { get; set; }
		int Id { get; set; }
		bool PreserveSystemFields { get; set; }
		bool ImportNotMappedFields { get; set; }
		bool SynchronizeFiles { get; set; }
    }
}
