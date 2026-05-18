using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InstanceExpressionCondition(SDK.InstanceExpressionCondition obj) : IInstanceExpressionCondition
    {
        internal SDK.InstanceExpressionCondition Obj { get; } = obj;

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
