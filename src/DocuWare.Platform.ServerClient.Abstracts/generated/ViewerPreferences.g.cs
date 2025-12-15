using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ViewerPreferences(SDK.ViewerPreferences obj) : IViewerPreferences
    {
        internal SDK.ViewerPreferences Obj { get; } = obj;

		public List<IAnnotationToolSettings> Annotations
		{
			get => Obj.Annotations.Select(x => new AnnotationToolSettings(x) as IAnnotationToolSettings).ToList();
			set => Obj.Annotations = value.Select(x => ((AnnotationToolSettings)x).Obj).ToList();
		}

		public List<IViewerToolbar> Toolbars
		{
			get => Obj.Toolbars.Select(x => new ViewerToolbar(x) as IViewerToolbar).ToList();
			set => Obj.Toolbars = value.Select(x => ((ViewerToolbar)x).Obj).ToList();
		}

		public string Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}

		public ToolbarVisibility LeftToolbarState
		{
			get => new oolbarVisibility(Obj.LeftToolbarState);
			set => Obj.LeftToolbarState = ((oolbarVisibility)value).Obj;
		}

		public ToolbarVisibility RightToolbarState
		{
			get => new oolbarVisibility(Obj.RightToolbarState);
			set => Obj.RightToolbarState = ((oolbarVisibility)value).Obj;
		}

		public bool ExpandStatusbar
		{
			get => Obj.ExpandStatusbar;
			set => Obj.ExpandStatusbar = value;
		}
    }
}
