using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowsQuery(DocuWare.Platform.ServerClient.DesignerWorkflowsQuery obj) : IDesignerWorkflowsQuery
    {
        internal DocuWare.Platform.ServerClient.DesignerWorkflowsQuery Obj { get; } = obj;

        public List<string> Workflows
        {
            get => Obj.Workflows;
            set => Obj.Workflows = value;
        }

        public bool LoadActiveInstanceCount
        {
            get => Obj.LoadActiveInstanceCount;
            set => Obj.LoadActiveInstanceCount = value;
        }

        public bool RemoveLinks
        {
            get => Obj.RemoveLinks;
            set => Obj.RemoveLinks = value;
        }
    }
}
