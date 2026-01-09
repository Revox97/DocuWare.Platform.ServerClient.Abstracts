using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWordSearchResultWordHits
    {
		List<IWordSearchResultWordHit> Wd { get; set; }
    }
}
