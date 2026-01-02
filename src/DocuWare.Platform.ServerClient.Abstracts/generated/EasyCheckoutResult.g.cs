using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutResult(SDK.EasyCheckoutResult obj) : IEasyCheckoutResult
    {
        internal SDK.EasyCheckoutResult Obj { get; } = obj;

		public void Dispose() => Obj.Dispose();
    }
}
