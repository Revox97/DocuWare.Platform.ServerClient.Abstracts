using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerToolbarControl
    {
		DocuWare.Platform.ServerClient.ToolbarControlType Type { get; set; }
		bool Checked { get; set; }
		DocuWare.Platform.ServerClient.ToolbarControlState State { get; set; }
    }
}
