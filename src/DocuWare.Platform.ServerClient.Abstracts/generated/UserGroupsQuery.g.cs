using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserGroupsQuery(DocuWare.Platform.ServerClient.UserGroupsQuery obj) : IUserGroupsQuery
    {
        internal DocuWare.Platform.ServerClient.UserGroupsQuery Obj { get; } = obj;

        public string UserId
        {
            get => Obj.UserId;
            set => Obj.UserId = value;
        }

        public bool Active
        {
            get => Obj.Active;
            set => Obj.Active = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
