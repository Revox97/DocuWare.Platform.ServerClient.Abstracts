using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowVersions(DocuWare.Platform.ServerClient.DesignerWorkflowVersions obj) : IDesignerWorkflowVersions
    {
        internal DocuWare.Platform.ServerClient.DesignerWorkflowVersions Obj { get; } = obj;

        public List<IDesignerWorkflowVersion> DesignerWorkflowVersion
        {
            get => Obj.DesignerWorkflowVersion.Select(x => new DesignerWorkflowVersion(x) as IDesignerWorkflowVersion).ToList();
            set => Obj.DesignerWorkflowVersion = value.Select(x => ((DesignerWorkflowVersion)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
