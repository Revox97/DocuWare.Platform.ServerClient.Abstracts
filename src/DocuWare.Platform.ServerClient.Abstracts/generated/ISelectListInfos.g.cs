using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListInfos{3}
    {
		List<ISelectListInfo> SelectLists { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
