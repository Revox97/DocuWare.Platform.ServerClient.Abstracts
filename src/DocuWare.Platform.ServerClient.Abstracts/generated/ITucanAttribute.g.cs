using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITucanAttribute
    {
		string MinumumVersion { get; set; }
		Object TypeId { get; }
    }
}
