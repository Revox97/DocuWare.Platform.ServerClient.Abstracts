using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumbatAttribute(DocuWare.Platform.ServerClient.NumbatAttribute obj) : INumbatAttribute
    {
        internal DocuWare.Platform.ServerClient.NumbatAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
