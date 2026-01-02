using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowDocumentHistory(DocuWare.Platform.ServerClient.WorkflowDocumentHistory obj) : IWorkflowDocumentHistory
    {
        internal DocuWare.Platform.ServerClient.WorkflowDocumentHistory Obj { get; } = obj;

        public List<IInstanceHistory> InstanceHistory
        {
            get => Obj.InstanceHistory.Select(x => new InstanceHistory(x) as IInstanceHistory).ToList();
            set => Obj.InstanceHistory = value.Select(x => ((InstanceHistory)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
