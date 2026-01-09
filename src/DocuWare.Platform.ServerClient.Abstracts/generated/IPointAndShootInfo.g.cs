using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPointAndShootInfo
    {
		List<IDWRectangle> Box { get; set; }
		int PageNumber { get; set; }
    }
}
