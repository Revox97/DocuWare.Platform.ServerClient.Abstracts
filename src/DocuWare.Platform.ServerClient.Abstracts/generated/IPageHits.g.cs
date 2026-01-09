using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPageHits
    {
		List<IWordSearchResultPageHit> PageHit { get; set; }
    }
}
