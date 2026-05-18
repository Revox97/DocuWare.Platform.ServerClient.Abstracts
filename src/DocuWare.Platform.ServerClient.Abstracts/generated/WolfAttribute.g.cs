using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WolfAttribute(DocuWare.Platform.ServerClient.WolfAttribute obj) : IWolfAttribute
    {
        internal DocuWare.Platform.ServerClient.WolfAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
