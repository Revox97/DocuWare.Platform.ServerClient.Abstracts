using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesResult(DocuWare.Platform.ServerClient.SelectListValuesResult obj) : ISelectListValuesResult
    {
        internal DocuWare.Platform.ServerClient.SelectListValuesResult Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
