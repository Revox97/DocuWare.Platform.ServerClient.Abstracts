using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfoConnectionData(SDK.IdentityServiceInfoConnectionData obj) : IIdentityServiceInfoConnectionData
    {
        internal SDK.IdentityServiceInfoConnectionData Obj { get; } = obj;

        public HttpMessageHandler HttpClientHandler
        {
            get => Obj.HttpClientHandler;
            set => Obj.HttpClientHandler = value;
        }

        public CancellationToken CancellationToken
        {
            get => Obj.CancellationToken;
            set => Obj.CancellationToken = value;
        }
    }
}
