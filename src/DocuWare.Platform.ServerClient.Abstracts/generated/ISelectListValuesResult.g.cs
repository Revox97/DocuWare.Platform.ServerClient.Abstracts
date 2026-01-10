using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValuesResult
    {
		ISingleColumnSelectListValues SingleColumn { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
