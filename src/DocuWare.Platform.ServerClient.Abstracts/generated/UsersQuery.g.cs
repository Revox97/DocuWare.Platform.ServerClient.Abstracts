using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UsersQuery(DocuWare.Platform.ServerClient.UsersQuery obj) : IUsersQuery
    {
        internal DocuWare.Platform.ServerClient.UsersQuery Obj { get; } = obj;

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
