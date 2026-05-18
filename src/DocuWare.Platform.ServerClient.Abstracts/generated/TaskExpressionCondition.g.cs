using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskExpressionCondition(DocuWare.Platform.ServerClient.TaskExpressionCondition obj) : ITaskExpressionCondition
    {
        internal DocuWare.Platform.ServerClient.TaskExpressionCondition Obj { get; } = obj;

        public List<string> Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }
    }
}
