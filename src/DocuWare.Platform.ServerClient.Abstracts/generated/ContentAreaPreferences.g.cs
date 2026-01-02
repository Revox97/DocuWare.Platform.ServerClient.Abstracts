using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentAreaPreferences(SDK.ContentAreaPreferences obj) : IContentAreaPreferences
    {
        internal SDK.ContentAreaPreferences Obj { get; } = obj;

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
