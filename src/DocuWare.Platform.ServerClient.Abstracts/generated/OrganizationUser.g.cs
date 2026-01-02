using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationUser(DocuWare.Platform.ServerClient.OrganizationUser obj) : IOrganizationUser
    {
        internal DocuWare.Platform.ServerClient.OrganizationUser Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
