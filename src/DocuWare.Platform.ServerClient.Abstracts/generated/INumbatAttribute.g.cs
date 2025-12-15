using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INumbatAttribute
    {
		string MinumumVersion { get; set; }
		Object TypeId { get; }
    }
}
