using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IKoalaAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
