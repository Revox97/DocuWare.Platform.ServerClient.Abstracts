using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPosition
    {
		int x { get; set; }
		int y { get; set; }
		int width { get; set; }
		int height { get; set; }
    }
}
