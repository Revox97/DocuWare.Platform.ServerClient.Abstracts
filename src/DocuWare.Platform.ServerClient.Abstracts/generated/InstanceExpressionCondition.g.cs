using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InstanceExpressionCondition(DocuWare.Platform.ServerClient.InstanceExpressionCondition obj) : IInstanceExpressionCondition
    {
        internal DocuWare.Platform.ServerClient.InstanceExpressionCondition Obj { get; } = obj;

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
