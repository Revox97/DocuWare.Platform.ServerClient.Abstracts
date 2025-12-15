using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkAreaPreferences(SDK.WorkAreaPreferences obj) : IWorkAreaPreferences
    {
        internal SDK.WorkAreaPreferences Obj { get; } = obj;

		public List<IContentAreaPreferences> ContentAreas
		{
			get => Obj.ContentAreas.Select(x => new ContentAreaPreferences(x) as IContentAreaPreferences).ToList();
			set => Obj.ContentAreas = value.Select(x => ((ContentAreaPreferences)x).Obj).ToList();
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}
    }
}
