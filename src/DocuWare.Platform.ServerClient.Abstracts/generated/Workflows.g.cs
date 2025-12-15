using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Workflows(SDK.Workflows obj) : IWorkflows
    {
        internal SDK.Workflows Obj { get; } = obj;

		public List<IWorkflow> Workflow
		{
			get => Obj.Workflow.Select(x => new Workflow(x) as IWorkflow).ToList();
			set => Obj.Workflow = value.Select(x => ((Workflow)x).Obj).ToList();
		}

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
