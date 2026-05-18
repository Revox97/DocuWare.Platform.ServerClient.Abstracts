using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DesignerWorkflowsQuery(SDK.DesignerWorkflowsQuery obj) : IDesignerWorkflowsQuery
    {
        internal SDK.DesignerWorkflowsQuery Obj { get; } = obj;

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
