using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowVersions(SDK.DesignerWorkflowVersions obj) : IDesignerWorkflowVersions
    {
        internal SDK.DesignerWorkflowVersions Obj { get; } = obj;

		public List<IDesignerWorkflowVersion> DesignerWorkflowVersion
		{
			get => Obj.DesignerWorkflowVersion.Select(x => new DesignerWorkflowVersion(x) as IDesignerWorkflowVersion).ToList();
			set => Obj.DesignerWorkflowVersion = value.Select(x => ((DesignerWorkflowVersion)x).Obj).ToList();
		}

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
