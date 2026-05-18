using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWaitingInstance
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string WorkflowVersionId { get; set; }
		WaitInstanceActivityType WaitInstanceActivityType { get; set; }
		string ActivityName { get; set; }
		int DocId { get; set; }
		DateTime TimeoutDate { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDesignerWaitingInstance GetDesignerWaitingInstanceFromSelfRelation();
		Task<DeserializedHttpResponse<IDesignerWaitingInstance>> GetDesignerWaitingInstanceFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWaitingInstance>> GetDesignerWaitingInstanceFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
