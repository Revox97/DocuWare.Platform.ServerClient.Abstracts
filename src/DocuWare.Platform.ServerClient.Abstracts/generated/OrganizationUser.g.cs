using SDK = DocuWare.Platform.ServerClient;

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

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
