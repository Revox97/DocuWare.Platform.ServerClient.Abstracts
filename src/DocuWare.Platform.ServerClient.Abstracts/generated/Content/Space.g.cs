using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class Space(SDK.Content.Space obj) : ISpace
    {
        internal SDK.Content.Space Obj { get; } = obj;

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }
    }
}
