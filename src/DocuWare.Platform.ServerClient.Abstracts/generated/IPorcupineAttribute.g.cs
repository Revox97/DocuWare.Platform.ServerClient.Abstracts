using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPorcupineAttribute
    {
		string MinumumVersion { get; set; }
		Object TypeId { get; }
    }
}
