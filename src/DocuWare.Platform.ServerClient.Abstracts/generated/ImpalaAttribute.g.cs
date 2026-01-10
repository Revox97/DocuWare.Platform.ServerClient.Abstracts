using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImpalaAttribute(DocuWare.Platform.ServerClient.ImpalaAttribute obj) : IImpalaAttribute
    {
        internal DocuWare.Platform.ServerClient.ImpalaAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
