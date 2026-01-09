using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPageData
    {
		IDWRectangle ContentArea { get; set; }
		int DpiX { get; set; }
		int DpiY { get; set; }
		int Width { get; set; }
		int Height { get; set; }
    }
}
