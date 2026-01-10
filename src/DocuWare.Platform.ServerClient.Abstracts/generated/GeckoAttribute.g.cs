using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeckoAttribute(DocuWare.Platform.ServerClient.GeckoAttribute obj) : IGeckoAttribute
    {
        internal DocuWare.Platform.ServerClient.GeckoAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
