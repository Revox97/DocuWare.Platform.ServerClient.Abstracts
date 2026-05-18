using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAutoNumberField : IWebFormField
    {
		int NumberGroupID { get; set; }
		string NumberGroupGuid { get; set; }
		string SourceFileCabinet { get; set; }
		int FontSize { get; set; }
		string FontColor { get; set; }
    }
}
