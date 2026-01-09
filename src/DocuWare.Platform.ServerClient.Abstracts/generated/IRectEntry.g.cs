using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRectEntry : IEntryBase
    {
		bool Filled { get; set; }
		bool Ellipse { get; set; }
    }
}
