using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RolesQuery(DocuWare.Platform.ServerClient.RolesQuery obj) : IRolesQuery
    {
        internal DocuWare.Platform.ServerClient.RolesQuery Obj { get; } = obj;

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

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
