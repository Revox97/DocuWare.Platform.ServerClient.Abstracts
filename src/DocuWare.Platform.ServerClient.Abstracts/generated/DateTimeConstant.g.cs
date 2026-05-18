using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateTimeConstant(SDK.DateTimeConstant obj) : IDateTimeConstant
    {
        internal SDK.DateTimeConstant Obj { get; } = obj;

        public DateTime? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
