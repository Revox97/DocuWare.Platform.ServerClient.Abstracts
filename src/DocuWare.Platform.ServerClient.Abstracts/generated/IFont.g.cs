using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFont{3}
    {
		string FontName { get; set; }
		bool Bold { get; set; }
		bool Italic { get; set; }
		bool Underlined { get; set; }
		bool StrikeThrough { get; set; }
		int FontSize { get; set; }
		int Spacing { get; set; }
    }
}
