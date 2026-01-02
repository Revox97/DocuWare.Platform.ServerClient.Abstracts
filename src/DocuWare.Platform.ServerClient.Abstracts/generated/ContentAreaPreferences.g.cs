using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentAreaPreferences(DocuWare.Platform.ServerClient.WebClient.ContentAreaPreferences obj) : IContentAreaPreferences
    {
        internal DocuWare.Platform.ServerClient.WebClient.ContentAreaPreferences Obj { get; } = obj;

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
