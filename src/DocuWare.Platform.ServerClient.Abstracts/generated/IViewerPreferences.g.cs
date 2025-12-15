using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerPreferences
    {
		List<IAnnotationToolSettings> Annotations { get; set; }
		List<IViewerToolbar> Toolbars { get; set; }
		string Id { get; set; }
		DocuWare.Platform.ServerClient.ToolbarVisibility LeftToolbarState { get; set; }
		DocuWare.Platform.ServerClient.ToolbarVisibility RightToolbarState { get; set; }
		bool ExpandStatusbar { get; set; }
    }
}
