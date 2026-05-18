using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableFieldInitialValues(SDK.TaskTableFieldInitialValues obj) : ITaskTableFieldInitialValues
    {
        internal SDK.TaskTableFieldInitialValues Obj { get; } = obj;

        public IDocumentIndexFieldTable DocumentIndexFieldTable
        {
            get => new DocumentIndexFieldTable(Obj.DocumentIndexFieldTable);
            set => Obj.DocumentIndexFieldTable = ((DocumentIndexFieldTable)value).Obj;
        }

        public TaskTableFieldJoinTypeEnum TaskTableFieldJoinType
        {
            get => (TaskTableFieldJoinTypeEnum)Obj.TaskTableFieldJoinType;
            set => Obj.TaskTableFieldJoinType = (DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum)value;
        }
    }
}
