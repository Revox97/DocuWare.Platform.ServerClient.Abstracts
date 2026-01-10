using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KoalaAttribute(DocuWare.Platform.ServerClient.KoalaAttribute obj) : IKoalaAttribute
    {
        internal DocuWare.Platform.ServerClient.KoalaAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
