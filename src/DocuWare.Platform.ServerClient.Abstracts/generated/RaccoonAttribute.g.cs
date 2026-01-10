using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RaccoonAttribute(DocuWare.Platform.ServerClient.RaccoonAttribute obj) : IRaccoonAttribute
    {
        internal DocuWare.Platform.ServerClient.RaccoonAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
