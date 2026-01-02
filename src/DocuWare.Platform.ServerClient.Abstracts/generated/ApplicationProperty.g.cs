using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationProperty(DocuWare.Platform.ServerClient.ApplicationProperty obj) : IApplicationProperty
    {
        internal DocuWare.Platform.ServerClient.ApplicationProperty Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
