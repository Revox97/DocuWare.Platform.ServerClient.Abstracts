using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingFiles(SDK.AdhocRenderingFiles obj) : IAdhocRenderingFiles
    {
        internal SDK.AdhocRenderingFiles Obj { get; } = obj;

        public List<IAdhocRenderingFile> Item
        {
            get => Obj.Item.Select(x => new AdhocRenderingFile(x) as IAdhocRenderingFile).ToList();
            set => Obj.Item = value.Select(x => ((AdhocRenderingFile)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
