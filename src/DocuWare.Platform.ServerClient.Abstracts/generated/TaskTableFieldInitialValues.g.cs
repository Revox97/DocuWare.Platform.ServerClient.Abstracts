using SDK = DocuWare.Platform.ServerClient;

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

        public DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum TaskTableFieldJoinType
        {
            get => Obj.TaskTableFieldJoinType;
            set => Obj.TaskTableFieldJoinType = value;
        }
    }
}
