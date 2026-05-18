using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationUser(SDK.OrganizationUser obj) : IOrganizationUser
    {
        internal SDK.OrganizationUser Obj { get; } = obj;

        public string OrganizationId
        {
            get => Obj.OrganizationId;
            set => Obj.OrganizationId = value;
        }

        public IUserInfo Info
        {
            get => new UserInfo(Obj.Info);
            set => Obj.Info = ((UserInfo)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
