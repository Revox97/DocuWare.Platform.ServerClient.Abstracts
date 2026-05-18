using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BooleanConstant(SDK.BooleanConstant obj) : IBooleanConstant
    {
        internal SDK.BooleanConstant Obj { get; } = obj;

        public bool? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
