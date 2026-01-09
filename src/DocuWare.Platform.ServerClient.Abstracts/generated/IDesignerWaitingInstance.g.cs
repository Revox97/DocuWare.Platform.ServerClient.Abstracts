using DocuWare.Platform.ServerClient;

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
