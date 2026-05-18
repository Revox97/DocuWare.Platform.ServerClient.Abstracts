using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberTableColumnOptions(SDK.NumberTableColumnOptions obj) : INumberTableColumnOptions
    {
        internal SDK.NumberTableColumnOptions Obj { get; } = obj;

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }
    }
}
