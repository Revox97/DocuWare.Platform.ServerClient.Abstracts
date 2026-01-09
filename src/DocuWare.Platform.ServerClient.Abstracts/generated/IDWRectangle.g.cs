using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDWRectangle
    {
		double Left { get; set; }
		double Top { get; set; }
		double Width { get; set; }
		double Height { get; set; }
    }
}
