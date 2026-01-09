using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentContent{3}
    {
		List<IKeyValuePair> metadata { get; set; }
		List<XElementWrapper> Embedded { get; set; }
		List<IPageContent> Pages { get; set; }
    }
}
