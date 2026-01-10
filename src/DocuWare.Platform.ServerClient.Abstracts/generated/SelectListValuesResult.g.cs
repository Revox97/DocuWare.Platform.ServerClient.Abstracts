using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesResult(DocuWare.Platform.ServerClient.SelectListValuesResult obj) : ISelectListValuesResult
    {
        internal DocuWare.Platform.ServerClient.SelectListValuesResult Obj { get; } = obj;

        public ISingleColumnSelectListValues SingleColumn
        {
            get => new SingleColumnSelectListValues(Obj.SingleColumn);
            set => Obj.SingleColumn = ((SingleColumnSelectListValues)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
