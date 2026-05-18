using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
