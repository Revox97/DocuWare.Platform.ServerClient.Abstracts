using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionCellValue
    {
		IPointAndShootInfo HighlightRectangle { get; set; }
		string TextFallback { get; set; }
		Decimal DecimalFallback { get; set; }
		bool DecimalFallbackSpecified { get; set; }
		DateTime DateFallback { get; set; }
		bool DateFallbackSpecified { get; set; }
		string ColumnName { get; set; }
		int RowNumber { get; set; }
		bool Mapped { get; set; }
		IPointAndShootInfo Source { get; set; }
		object Item { get; set; }
		DocuWare.Platform.ServerClient.ItemChoiceType ItemElementName { get; set; }
    }
}
