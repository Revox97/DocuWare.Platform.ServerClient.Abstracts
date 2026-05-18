using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkParameter(SDK.LinkParameter obj) : ILinkParameter
    {
        internal SDK.LinkParameter Obj { get; } = obj;

        public string Url
        {
            get => Obj.Url;
            set => Obj.Url = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }
    }
}
