using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowTask(SDK.WorkflowTask obj) : IWorkflowTask
    {
        internal SDK.WorkflowTask Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public ITaskOperations TaskOperations
        {
            get => new TaskOperations(Obj.TaskOperations);
            set => Obj.TaskOperations = ((TaskOperations)value).Obj;
        }

        public List<IColumnValue> ColumnValues
        {
            get => Obj.ColumnValues.Select(x => new ColumnValue(x) as IColumnValue).ToList();
            set => Obj.ColumnValues = value.Select(x => ((ColumnValue)x).Obj).ToList();
        }

        public List<IDecision> Decisions
        {
            get => Obj.Decisions.Select(x => new Decision(x) as IDecision).ToList();
            set => Obj.Decisions = value.Select(x => ((Decision)x).Obj).ToList();
        }

        public int? DefaultDecisionId
        {
            get => Obj.DefaultDecisionId;
            set => Obj.DefaultDecisionId = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string InstanceId
        {
            get => Obj.InstanceId;
            set => Obj.InstanceId = value;
        }

        public bool IsRead
        {
            get => Obj.IsRead;
            set => Obj.IsRead = value;
        }

        public bool AllowDecisionStamp
        {
            get => Obj.AllowDecisionStamp;
            set => Obj.AllowDecisionStamp = value;
        }

        public string ActivityDescription
        {
            get => Obj.ActivityDescription;
            set => Obj.ActivityDescription = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public DocuWare.Platform.ServerClient.ActivityTypeEnum ActivityType
        {
            get => Obj.ActivityType;
            set => Obj.ActivityType = value;
        }

        public int NodeId
        {
            get => Obj.NodeId;
            set => Obj.NodeId = value;
        }

        public string WorkflowVersionId
        {
            get => Obj.WorkflowVersionId;
            set => Obj.WorkflowVersionId = value;
        }

        public bool LockDocument
        {
            get => Obj.LockDocument;
            set => Obj.LockDocument = value;
        }

        public bool HasDocumentFields
        {
            get => Obj.HasDocumentFields;
            set => Obj.HasDocumentFields = value;
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
