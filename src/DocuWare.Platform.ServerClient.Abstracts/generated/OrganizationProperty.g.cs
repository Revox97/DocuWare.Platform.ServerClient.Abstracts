using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationProperty(DocuWare.Platform.ServerClient.OrganizationProperty obj) : IOrganizationProperty
    {
        internal DocuWare.Platform.ServerClient.OrganizationProperty Obj { get; } = obj;

        public string Key
        {
            get => Obj.Key;
            set => Obj.Key = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
