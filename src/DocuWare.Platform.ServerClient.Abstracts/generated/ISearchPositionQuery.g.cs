using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISearchPositionQuery
    {
		string Phrase { get; set; }
		bool IgnoreCase { get; set; }
		bool WholeWord { get; set; }
		int StartPage { get; set; }
		int StartSectionNumber { get; set; }
		int PageCount { get; set; }
		bool Backward { get; set; }
		bool RangeSearch { get; set; }
		bool Normalize { get; set; }
		bool ExactPhrase { get; set; }
    }
}
