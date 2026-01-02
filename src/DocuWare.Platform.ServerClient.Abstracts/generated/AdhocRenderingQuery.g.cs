using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingQuery(SDK.AdhocRenderingQuery obj) : IAdhocRenderingQuery
    {
        internal SDK.AdhocRenderingQuery Obj { get; } = obj;

        public int Page
        {
            get => Obj.Page;
            set => Obj.Page = value;
        }

        public float Dpi
        {
            get => Obj.Dpi;
            set => Obj.Dpi = value;
        }

        public string ApiKey
        {
            get => Obj.ApiKey;
            set => Obj.ApiKey = value;
        }
    }
}
