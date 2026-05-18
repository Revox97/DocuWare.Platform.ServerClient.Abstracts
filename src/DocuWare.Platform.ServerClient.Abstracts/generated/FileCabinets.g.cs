using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinets(SDK.FileCabinets obj) : IFileCabinets
    {
        internal SDK.FileCabinets Obj { get; } = obj;

        public List<IFileCabinet> FileCabinet
        {
            get => Obj.FileCabinet.Select(x => new FileCabinet(x) as IFileCabinet).ToList();
            set => Obj.FileCabinet = value.Select(x => ((FileCabinet)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
