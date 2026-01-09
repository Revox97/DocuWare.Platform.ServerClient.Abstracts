using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWordSearchResultPageHit
    {
		List<IWordSearchResultWordHit> Hits { get; set; }
		int PageNum { get; set; }
    }
}
