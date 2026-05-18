using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowDocumentHistory(SDK.WorkflowDocumentHistory obj) : IWorkflowDocumentHistory
    {
        internal SDK.WorkflowDocumentHistory Obj { get; } = obj;

        public List<IInstanceHistory> InstanceHistory
        {
            get => Obj.InstanceHistory.Select(x => new InstanceHistory(x) as IInstanceHistory).ToList();
            set => Obj.InstanceHistory = value.Select(x => ((InstanceHistory)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
