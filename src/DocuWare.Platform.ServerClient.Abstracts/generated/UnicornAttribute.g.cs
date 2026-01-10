using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UnicornAttribute(DocuWare.Platform.ServerClient.UnicornAttribute obj) : IUnicornAttribute
    {
        internal DocuWare.Platform.ServerClient.UnicornAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
