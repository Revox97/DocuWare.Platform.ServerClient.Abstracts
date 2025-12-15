using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserGroupsQuery(SDK.UserGroupsQuery obj) : IUserGroupsQuery
    {
        internal SDK.UserGroupsQuery Obj { get; } = obj;

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

        public bool ActiveSpecified
        {
            get => Obj.ActiveSpecified;
            set => Obj.ActiveSpecified = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
