using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFontSettings
    {
		string Name { get; set; }
		string Size { get; set; }
		bool Bold { get; set; }
		bool Italic { get; set; }
		bool Underline { get; set; }
		bool Strikeout { get; set; }
    }
}
