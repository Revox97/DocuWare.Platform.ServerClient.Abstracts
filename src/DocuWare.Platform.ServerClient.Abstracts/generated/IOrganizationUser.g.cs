using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizationUser
    {
		string OrganizationId { get; set; }
		IUserInfo Info { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
