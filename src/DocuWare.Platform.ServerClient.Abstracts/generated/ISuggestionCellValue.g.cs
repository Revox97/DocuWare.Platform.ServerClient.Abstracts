using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionCellValue: ISuggestionValue
    {
		string TextFallback { get; set; }
		Decimal DecimalFallback { get; set; }
		DateTime DateFallback { get; set; }
		string ColumnName { get; set; }
		int RowNumber { get; set; }
		bool Mapped { get; set; }
		object Item { get; set; }
    }
}
