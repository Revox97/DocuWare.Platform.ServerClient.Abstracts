using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RolesQuery(SDK.RolesQuery obj) : IRolesQuery
    {
        internal SDK.RolesQuery Obj { get; } = obj;

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

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
