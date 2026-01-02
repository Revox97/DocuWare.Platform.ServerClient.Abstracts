using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesResult(SDK.SelectListValuesResult obj) : ISelectListValuesResult
    {
        internal SDK.SelectListValuesResult Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
