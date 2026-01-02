using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflows(DocuWare.Platform.ServerClient.DesignerWorkflows obj) : IDesignerWorkflows
    {
        internal DocuWare.Platform.ServerClient.DesignerWorkflows Obj { get; } = obj;

        public List<IDesignerWorkflow> Workflow
        {
            get => Obj.Workflow.Select(x => new DesignerWorkflow(x) as IDesignerWorkflow).ToList();
            set => Obj.Workflow = value.Select(x => ((DesignerWorkflow)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
