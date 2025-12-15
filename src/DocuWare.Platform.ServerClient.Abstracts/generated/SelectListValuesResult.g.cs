using SDK = DocuWare.Platform.ServerClient;

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

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
