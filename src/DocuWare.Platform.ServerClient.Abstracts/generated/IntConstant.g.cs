using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntConstant(SDK.IntConstant obj) : IIntConstant
    {
        internal SDK.IntConstant Obj { get; } = obj;

        public int? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
