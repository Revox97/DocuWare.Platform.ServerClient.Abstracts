using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SystemVariableExpression(SDK.SystemVariableExpression obj) : ISystemVariableExpression
    {
        internal SDK.SystemVariableExpression Obj { get; } = obj;

        public string VariableName
        {
            get => Obj.VariableName;
            set => Obj.VariableName = value;
        }
    }
}
