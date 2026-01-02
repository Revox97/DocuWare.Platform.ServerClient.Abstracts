using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Users(SDK.Users obj) : IUsers
    {
        internal SDK.Users Obj { get; } = obj;

        public List<IUser> User
        {
            get => Obj.User.Select(x => new User(x) as IUser).ToList();
            set => Obj.User = value.Select(x => ((User)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
