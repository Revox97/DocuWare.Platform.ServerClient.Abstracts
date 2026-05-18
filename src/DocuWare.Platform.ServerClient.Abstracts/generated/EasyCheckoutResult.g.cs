using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutResult(SDK.EasyCheckoutResult obj) : IEasyCheckoutResult
    {
        internal SDK.EasyCheckoutResult Obj { get; } = obj;

        public string EncodedFileName => Obj.EncodedFileName;

        public DeserializedHttpResponse<Stream> Response => Obj.Response;

		public void Dispose() => Obj.Dispose();
    }
}
