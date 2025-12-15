using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutResult(SDK.EasyCheckoutResult obj) : IEasyCheckoutResult
    {
        internal SDK.EasyCheckoutResult Obj { get; } = obj;

		public string EncodedFileName => Obj.EncodedFileName;

		public DeserializedHttpResponse<Stream> Response => Obj.Response;

		public async void Dispose() => Obj.Dispose();
    }
}
