using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecimalConstant(SDK.DecimalConstant obj) : IDecimalConstant
    {
        internal SDK.DecimalConstant Obj { get; } = obj;

        public Decimal? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
