using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
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
