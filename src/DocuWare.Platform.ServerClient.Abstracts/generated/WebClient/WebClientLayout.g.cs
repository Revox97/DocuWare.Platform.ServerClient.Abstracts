using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class WebClientLayout(SDK.WebClient.WebClientLayout obj) : IWebClientLayout
    {
        internal SDK.WebClient.WebClientLayout Obj { get; } = obj;

        public LayoutMode Mode
        {
            get => (LayoutMode)Obj.Mode;
            set => Obj.Mode = (DocuWare.Platform.ServerClient.WebClient.LayoutMode)value;
        }
    }
}
