using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutResult(DocuWare.Platform.ServerClient.EasyCheckoutResult obj) : IEasyCheckoutResult
    {
        internal DocuWare.Platform.ServerClient.EasyCheckoutResult Obj { get; } = obj;

		public void Dispose() => Obj.Dispose();
    }
}
