using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IViewerToolbarControl{3}
    {
		ToolbarControlType Type { get; set; }
		bool Checked { get; set; }
		ToolbarControlState State { get; set; }
    }
}
