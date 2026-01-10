using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DolphinAttribute(DocuWare.Platform.ServerClient.DolphinAttribute obj) : IDolphinAttribute
    {
        internal DocuWare.Platform.ServerClient.DolphinAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
