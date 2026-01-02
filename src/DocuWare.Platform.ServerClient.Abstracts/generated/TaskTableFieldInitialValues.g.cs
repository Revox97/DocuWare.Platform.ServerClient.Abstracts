using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableFieldInitialValues(DocuWare.Platform.ServerClient.TaskTableFieldInitialValues obj) : ITaskTableFieldInitialValues
    {
        internal DocuWare.Platform.ServerClient.TaskTableFieldInitialValues Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum TaskTableFieldJoinType
        {
            get => Obj.TaskTableFieldJoinType;
            set => Obj.TaskTableFieldJoinType = value;
        }
    }
}
