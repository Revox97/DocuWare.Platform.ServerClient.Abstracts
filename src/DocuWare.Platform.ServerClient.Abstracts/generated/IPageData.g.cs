using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPageData
    {
		int LowQualitySize { get; set; }
		int TileSize { get; set; }
		PlatformImageFormat RenderedImageFormat { get; set; }
		IDWRectangle ContentArea { get; set; }
		int DpiX { get; set; }
		int DpiY { get; set; }
		int Width { get; set; }
		int Height { get; set; }
    }
}
