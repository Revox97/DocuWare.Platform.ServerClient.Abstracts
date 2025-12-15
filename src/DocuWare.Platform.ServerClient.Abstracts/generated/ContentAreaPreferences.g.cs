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

		public WorkAreaType AreaType
		{
			get => new orkAreaType(Obj.AreaType);
			set => Obj.AreaType = ((orkAreaType)value).Obj;
		}

		public int SelectedInstanceIndex
		{
			get => Obj.SelectedInstanceIndex;
			set => Obj.SelectedInstanceIndex = value;
		}

		public bool SelectedInstanceIndexSpecified
		{
			get => Obj.SelectedInstanceIndexSpecified;
			set => Obj.SelectedInstanceIndexSpecified = value;
		}
    }
}
