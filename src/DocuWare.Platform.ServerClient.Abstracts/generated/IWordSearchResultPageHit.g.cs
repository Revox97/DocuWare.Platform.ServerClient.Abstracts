using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWordSearchResultPageHit{3}
    {
		List<IWordSearchResultWordHit> Hits { get; set; }
		int PageNum { get; set; }
    }
}
