using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColSelectListInfos{3}
    {
		List<IMultiColSelectListInfo> MultiColSelectLists { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
