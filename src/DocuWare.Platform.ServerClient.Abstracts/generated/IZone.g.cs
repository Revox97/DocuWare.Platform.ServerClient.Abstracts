using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IZone
    {
		int ZoneID { get; set; }
		string Type { get; set; }
		int PageNumber { get; set; }
		int X { get; set; }
		int Y { get; set; }
		int W { get; set; }
		int H { get; set; }
		string MappedWebFormFieldName { get; set; }
		string MappedWebFormFieldType { get; set; }
		string FillAreaName { get; set; }
		string SampleText { get; set; }
		string FontType { get; set; }
		int FontSize { get; set; }
		string FontColor { get; set; }
		bool FontWeightBold { get; set; }
		bool FontWeightItalic { get; set; }
		bool FontWeightUnderlined { get; set; }
		AlignmentType TextAlignment { get; set; }
		int OriginalImageWidth { get; set; }
		bool WrapText { get; set; }
    }
}
