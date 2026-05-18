using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWaitingInstances(SDK.DesignerWaitingInstances obj) : IDesignerWaitingInstances
    {
        internal SDK.DesignerWaitingInstances Obj { get; } = obj;

        public List<IDesignerWaitingInstance> DesignerWaitingInstance
        {
            get => Obj.DesignerWaitingInstance.Select(x => new DesignerWaitingInstance(x) as IDesignerWaitingInstance).ToList();
            set => Obj.DesignerWaitingInstance = value.Select(x => ((DesignerWaitingInstance)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
