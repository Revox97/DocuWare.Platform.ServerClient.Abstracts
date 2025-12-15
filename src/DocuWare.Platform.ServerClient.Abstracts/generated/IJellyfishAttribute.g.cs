using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IJellyfishAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
