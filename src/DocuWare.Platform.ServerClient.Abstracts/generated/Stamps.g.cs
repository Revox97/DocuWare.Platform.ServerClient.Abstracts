using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Stamps(SDK.Stamps obj) : IStamps
    {
        internal SDK.Stamps Obj { get; } = obj;

        public List<IStamp> Stamp
        {
            get => Obj.Stamp.Select(x => new Stamp(x) as IStamp).ToList();
            set => Obj.Stamp = value.Select(x => ((Stamp)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
