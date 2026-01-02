using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableFieldInitialValues(DocuWare.Platform.ServerClient.TaskTableFieldInitialValues obj) : ITaskTableFieldInitialValues
    {
        internal DocuWare.Platform.ServerClient.TaskTableFieldInitialValues Obj { get; } = obj;

        public TaskTableFieldJoinTypeEnum TaskTableFieldJoinType
        {
            get => (TaskTableFieldJoinTypeEnum)Obj.TaskTableFieldJoinType;
            set => Obj.TaskTableFieldJoinType = (DocuWare.Platform.ServerClient.TaskTableFieldJoinTypeEnum)value;
        }
    }
}
