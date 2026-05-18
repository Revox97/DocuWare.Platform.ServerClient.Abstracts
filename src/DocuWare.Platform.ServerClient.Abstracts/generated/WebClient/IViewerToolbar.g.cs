using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public interface IViewerToolbar
    {
		List<IViewerToolbarControl> Controls { get; set; }
		ViewerToolbarType Type { get; set; }
		ToolbarPosition Position { get; set; }
		ToolbarVisibility Visibility { get; set; }
    }
}
