using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingQuery(SDK.AdhocRenderingQuery obj) : IAdhocRenderingQuery
    {
        internal SDK.AdhocRenderingQuery Obj { get; } = obj;

        public IDWSize Size
        {
            get => new DWSize(Obj.Size);
            set => Obj.Size = ((DWSize)value).Obj;
        }

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
