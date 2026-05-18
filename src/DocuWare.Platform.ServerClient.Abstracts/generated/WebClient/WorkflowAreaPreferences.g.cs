using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class WorkflowAreaPreferences(SDK.WebClient.WorkflowAreaPreferences obj) : IWorkflowAreaPreferences
    {
        internal SDK.WebClient.WorkflowAreaPreferences Obj { get; } = obj;

        public List<IWorkInstance> ControllerInstances
        {
            get => Obj.ControllerInstances.Select(x => new WorkInstance(x) as IWorkInstance).ToList();
            set => Obj.ControllerInstances = value.Select(x => ((WorkInstance)x).Obj).ToList();
        }

        public string SelectedControllerInstanceGuid
        {
            get => Obj.SelectedControllerInstanceGuid;
            set => Obj.SelectedControllerInstanceGuid = value;
        }

        public string SelectedInstanceGuid
        {
            get => Obj.SelectedInstanceGuid;
            set => Obj.SelectedInstanceGuid = value;
        }

        public List<IWorkInstance> Instances
        {
            get => Obj.Instances.Select(x => new WorkInstance(x) as IWorkInstance).ToList();
            set => Obj.Instances = value.Select(x => ((WorkInstance)x).Obj).ToList();
        }

        public WorkAreaType AreaType
        {
            get => (WorkAreaType)Obj.AreaType;
            set => Obj.AreaType = (DocuWare.Platform.ServerClient.WebClient.WorkAreaType)value;
        }

        public int SelectedInstanceIndex
        {
            get => Obj.SelectedInstanceIndex;
            set => Obj.SelectedInstanceIndex = value;
        }
    }
}
