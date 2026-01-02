using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Workflows(DocuWare.Platform.ServerClient.Workflows obj) : IWorkflows
    {
        internal DocuWare.Platform.ServerClient.Workflows Obj { get; } = obj;

        public List<IWorkflow> Workflow
        {
            get => Obj.Workflow.Select(x => new Workflow(x) as IWorkflow).ToList();
            set => Obj.Workflow = value.Select(x => ((Workflow)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
