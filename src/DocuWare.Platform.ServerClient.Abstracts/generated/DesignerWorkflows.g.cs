using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflows(SDK.DesignerWorkflows obj) : IDesignerWorkflows
    {
        internal SDK.DesignerWorkflows Obj { get; } = obj;

		public List<IDesignerWorkflow> Workflow
		{
			get => Obj.Workflow.Select(x => new DesignerWorkflow(x) as IDesignerWorkflow).ToList();
			set => Obj.Workflow = value.Select(x => ((DesignerWorkflow)x).Obj).ToList();
		}

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
