using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesResult(SDK.SelectListValuesResult obj) : ISelectListValuesResult
    {
        internal SDK.SelectListValuesResult Obj { get; } = obj;

        public ISingleColumnSelectListValues SingleColumn
        {
            get => new SingleColumnSelectListValues(Obj.SingleColumn);
            set => Obj.SingleColumn = ((SingleColumnSelectListValues)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
