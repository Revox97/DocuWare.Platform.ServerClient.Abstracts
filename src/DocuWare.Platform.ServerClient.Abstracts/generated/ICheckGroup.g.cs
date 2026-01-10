using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckGroup : IWebFormField
    {
		List<IWebFormOption> Options { get; set; }
		OrientationType Orientation { get; set; }
		int NumberOfColumns { get; set; }
		ColumnWidthType ColumnWidth { get; set; }
		string SortOrder { get; set; }
		List<List<IWebFormOption>> OptionsRows { get; set; }
		List<string> PredefinedValues { get; set; }
    }
}
