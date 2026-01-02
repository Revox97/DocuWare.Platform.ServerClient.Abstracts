using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowAreaPreferences(SDK.WorkflowAreaPreferences obj) : IWorkflowAreaPreferences
    {
        internal SDK.WorkflowAreaPreferences Obj { get; } = obj;

        public List<IWorkInstance> ControllerInstances
        {
            get => Obj.ControllerInstances.Select(x => new WorkInstance(x) as IWorkInstance).ToList();
            set => Obj.ControllerInstances = value.Select(x => ((WorkInstance)x).Obj).ToList();
        }

        public List<IWorkInstance> Instances
        {
            get => Obj.Instances.Select(x => new WorkInstance(x) as IWorkInstance).ToList();
            set => Obj.Instances = value.Select(x => ((WorkInstance)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.WorkAreaType AreaType
        {
            get => Obj.AreaType;
            set => Obj.AreaType = value;
        }

        public int SelectedInstanceIndex
        {
            get => Obj.SelectedInstanceIndex;
            set => Obj.SelectedInstanceIndex = value;
        }
    }
}
