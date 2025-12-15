using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowTask
    {
		Link[] Links { get; set; }
		ITaskOperations TaskOperations { get; set; }
		List<IColumnValue> ColumnValues { get; set; }
		List<IDecision> Decisions { get; set; }
		int? DefaultDecisionId { get; set; }
		string Id { get; set; }
		string InstanceId { get; set; }
		bool IsRead { get; set; }
		bool AllowDecisionStamp { get; set; }
		string ActivityDescription { get; set; }
		int DocId { get; set; }
		DocuWare.Platform.ServerClient.ActivityTypeEnum ActivityType { get; set; }
		int NodeId { get; set; }
		string WorkflowVersionId { get; set; }
		bool LockDocument { get; set; }
		bool HasDocumentFields { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
