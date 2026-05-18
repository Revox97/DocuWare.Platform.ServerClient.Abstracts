using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfirmedField(SDK.ConfirmedField obj) : IConfirmedField
    {
        internal SDK.ConfirmedField Obj { get; } = obj;

        public IWFFormFieldValue Value
        {
            get => new WFFormFieldValue(Obj.Value);
            set => Obj.Value = ((WFFormFieldValue)value).Obj;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
