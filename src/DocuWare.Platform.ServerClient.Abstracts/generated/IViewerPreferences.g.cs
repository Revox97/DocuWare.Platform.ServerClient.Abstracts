using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerPreferences{3}
    {
		List<IAnnotationToolSettings> Annotations { get; set; }
		List<IViewerToolbar> Toolbars { get; set; }
		string Id { get; set; }
		ToolbarVisibility LeftToolbarState { get; set; }
		ToolbarVisibility RightToolbarState { get; set; }
		bool ExpandStatusbar { get; set; }
    }
}
