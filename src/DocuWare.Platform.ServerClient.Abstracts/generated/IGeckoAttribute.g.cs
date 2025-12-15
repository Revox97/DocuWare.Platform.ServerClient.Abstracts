using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGeckoAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
