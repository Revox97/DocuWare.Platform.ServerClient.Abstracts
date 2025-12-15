using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAutoNumberField
    {
		int NumberGroupID { get; set; }
		string NumberGroupGuid { get; set; }
		string SourceFileCabinet { get; set; }
		int FontSize { get; set; }
		string FontColor { get; set; }
		string Value { get; set; }
		string Type { get; set; }
		bool Hidden { get; set; }
		bool Readonly { get; set; }
		bool Required { get; set; }
		string Hint { get; set; }
		string ValidationID { get; set; }
		string ID { get; set; }
		string Label { get; set; }
		IPosition Position { get; set; }
		string BehaviorID { get; set; }
    }
}
