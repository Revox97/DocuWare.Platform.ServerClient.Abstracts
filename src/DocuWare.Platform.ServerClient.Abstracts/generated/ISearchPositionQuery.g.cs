using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISearchPositionQuery
    {
		bool IgnoreCase { get; set; }
		bool WholeWord { get; set; }
		int StartPage { get; set; }
		int StartSectionNumber { get; set; }
		int PageCount { get; set; }
		bool Backward { get; set; }
		bool RangeSearch { get; set; }
		bool Normalize { get; set; }
    }
}
