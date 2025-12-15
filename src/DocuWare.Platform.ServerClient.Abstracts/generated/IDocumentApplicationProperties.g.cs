using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentApplicationProperties
    {
		List<IDocumentApplicationProperty> DocumentApplicationProperty { get; set; }
    }
}
