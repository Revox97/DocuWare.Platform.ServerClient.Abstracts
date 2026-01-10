using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FoxAttribute(DocuWare.Platform.ServerClient.FoxAttribute obj) : IFoxAttribute
    {
        internal DocuWare.Platform.ServerClient.FoxAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
