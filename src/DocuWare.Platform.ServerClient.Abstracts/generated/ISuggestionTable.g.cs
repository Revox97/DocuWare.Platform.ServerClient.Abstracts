using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionTable{3}
    {
		List<ISuggestionCellValue> Cell { get; set; }
		List<IPointAndShootInfo> HighlightRectangle { get; set; }
		double Trust { get; set; }
    }
}
