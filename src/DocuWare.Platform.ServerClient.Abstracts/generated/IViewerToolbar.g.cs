using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerToolbar
    {
		List<IViewerToolbarControl> Controls { get; set; }
		DocuWare.Platform.ServerClient.ViewerToolbarType Type { get; set; }
		DocuWare.Platform.ServerClient.ToolbarPosition Position { get; set; }
		DocuWare.Platform.ServerClient.ToolbarVisibility Visibility { get; set; }
    }
}
