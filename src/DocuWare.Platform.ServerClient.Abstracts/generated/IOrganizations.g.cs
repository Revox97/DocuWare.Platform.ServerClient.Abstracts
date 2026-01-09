using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizations{3}
    {
		List<IOrganization> Organization { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
