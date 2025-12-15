using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerToolbar
    {
		List<IViewerToolbarControl> Controls { get; set; }
		ViewerToolbarType Type { get; set; }
		ToolbarPosition Position { get; set; }
		ToolbarVisibility Visibility { get; set; }
    }
}
