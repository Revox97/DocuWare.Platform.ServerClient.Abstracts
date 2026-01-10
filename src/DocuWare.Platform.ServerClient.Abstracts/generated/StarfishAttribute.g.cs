using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StarfishAttribute(DocuWare.Platform.ServerClient.StarfishAttribute obj) : IStarfishAttribute
    {
        internal DocuWare.Platform.ServerClient.StarfishAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
