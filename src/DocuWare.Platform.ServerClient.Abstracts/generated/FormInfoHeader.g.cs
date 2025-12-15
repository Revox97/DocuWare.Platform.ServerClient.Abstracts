using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfoHeader(SDK.FormInfoHeader obj) : IFormInfoHeader
    {
        internal SDK.FormInfoHeader Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string SanitizedName
        {
            get => Obj.SanitizedName;
            set => Obj.SanitizedName = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public bool Usage
        {
            get => Obj.Usage;
            set => Obj.Usage = value;
        }

        public bool Admin
        {
            get => Obj.Admin;
            set => Obj.Admin = value;
        }

        public bool Active
        {
            get => Obj.Active;
            set => Obj.Active = value;
        }

        public bool Public
        {
            get => Obj.Public;
            set => Obj.Public = value;
        }
    }
}
