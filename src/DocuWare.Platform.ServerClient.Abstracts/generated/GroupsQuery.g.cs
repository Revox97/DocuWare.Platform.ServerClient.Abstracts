using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GroupsQuery(DocuWare.Platform.ServerClient.GroupsQuery obj) : IGroupsQuery
    {
        internal DocuWare.Platform.ServerClient.GroupsQuery Obj { get; } = obj;

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
