using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILobsterAttribute
    {
		string MinumumVersion { get; set; }
		Object TypeId { get; }
    }
}
