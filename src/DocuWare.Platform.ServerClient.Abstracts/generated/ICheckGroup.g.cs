using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckGroup
    {
		List<IWebFormOption> Options { get; set; }
		OrientationType Orientation { get; set; }
		int NumberOfColumns { get; set; }
		ColumnWidthType ColumnWidth { get; set; }
		string SortOrder { get; set; }
		List<List<IWebFormOption>> OptionsRows { get; set; }
		List<string> PredefinedValues { get; set; }
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
