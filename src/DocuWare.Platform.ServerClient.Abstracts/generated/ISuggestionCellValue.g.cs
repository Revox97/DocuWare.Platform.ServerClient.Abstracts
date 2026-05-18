using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionCellValue : ISuggestionValue
    {
		IPointAndShootInfo HighlightRectangle { get; set; }
		string TextFallback { get; set; }
		Decimal DecimalFallback { get; set; }
		DateTime DateFallback { get; set; }
		string ColumnName { get; set; }
		int RowNumber { get; set; }
		bool Mapped { get; set; }
    }
}
