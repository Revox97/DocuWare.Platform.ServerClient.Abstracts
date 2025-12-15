using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentWordSearchResultSectionHits
    {
		List<IWordSearchResultPageHit> PageHits { get; set; }
		string SectionId { get; set; }
    }
}
