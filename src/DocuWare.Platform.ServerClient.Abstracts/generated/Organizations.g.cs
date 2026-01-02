using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Organizations(DocuWare.Platform.ServerClient.Organizations obj) : IOrganizations
    {
        internal DocuWare.Platform.ServerClient.Organizations Obj { get; } = obj;

        public List<IOrganization> Organization
        {
            get => Obj.Organization.Select(x => new Organization(x) as IOrganization).ToList();
            set => Obj.Organization = value.Select(x => ((Organization)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
