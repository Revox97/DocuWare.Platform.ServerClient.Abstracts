using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationUser(DocuWare.Platform.ServerClient.OrganizationUser obj) : IOrganizationUser
    {
        internal DocuWare.Platform.ServerClient.OrganizationUser Obj { get; } = obj;

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
