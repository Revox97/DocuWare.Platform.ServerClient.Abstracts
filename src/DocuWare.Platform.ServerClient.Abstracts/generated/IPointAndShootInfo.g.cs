using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPointAndShootInfo{3}
    {
		List<IDWRectangle> Box { get; set; }
		int PageNumber { get; set; }
    }
}
