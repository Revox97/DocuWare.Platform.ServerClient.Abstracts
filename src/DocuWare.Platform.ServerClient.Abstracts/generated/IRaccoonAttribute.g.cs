using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRaccoonAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
