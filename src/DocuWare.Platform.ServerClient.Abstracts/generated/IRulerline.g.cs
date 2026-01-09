using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRulerline : IRectangleBase
    {
		int lineWidth { get; set; }
		LineStyle style { get; set; }
    }
}
