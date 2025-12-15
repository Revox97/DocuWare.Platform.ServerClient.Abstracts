using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IQuokkaAttribute
    {
		string MinumumVersion { get; set; }
		Object TypeId { get; }
    }
}
