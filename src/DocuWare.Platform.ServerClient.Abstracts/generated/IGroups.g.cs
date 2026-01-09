using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGroups
    {
		List<IGroup> Item { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
