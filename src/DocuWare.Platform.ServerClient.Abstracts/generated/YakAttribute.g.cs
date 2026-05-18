using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class YakAttribute(DocuWare.Platform.ServerClient.YakAttribute obj) : IYakAttribute
    {
        internal DocuWare.Platform.ServerClient.YakAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;
    }
}
