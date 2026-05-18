using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOption(SDK.WebFormOption obj) : IWebFormOption
    {
        internal SDK.WebFormOption Obj { get; } = obj;

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public bool Checked
        {
            get => Obj.Checked;
            set => Obj.Checked = value;
        }
    }
}
