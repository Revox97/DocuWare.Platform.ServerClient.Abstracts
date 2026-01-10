using DocuWare.Platform.ServerClient;

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
