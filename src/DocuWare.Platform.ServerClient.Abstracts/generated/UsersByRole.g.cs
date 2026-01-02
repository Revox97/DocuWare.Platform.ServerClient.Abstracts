using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UsersByRole(DocuWare.Platform.ServerClient.UsersByRole obj) : IUsersByRole
    {
        internal DocuWare.Platform.ServerClient.UsersByRole Obj { get; } = obj;

        public List<IUser> User
        {
            get => Obj.User.Select(x => new User(x) as IUser).ToList();
            set => Obj.User = value.Select(x => ((User)x).Obj).ToList();
        }

        public string RoleId
        {
            get => Obj.RoleId;
            set => Obj.RoleId = value;
        }

        public bool IncludeGroupUsers
        {
            get => Obj.IncludeGroupUsers;
            set => Obj.IncludeGroupUsers = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
