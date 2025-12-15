using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Organizations(SDK.Organizations obj) : IOrganizations
    {
        internal SDK.Organizations Obj { get; } = obj;

        public List<IOrganization> Organization
        {
            get => Obj.Organization.Select(x => new Organization(x) as IOrganization).ToList();
            set => Obj.Organization = value.Select(x => ((Organization)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
