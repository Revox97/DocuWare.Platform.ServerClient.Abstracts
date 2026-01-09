using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchAppendKeywordValues
    {
		List<int> DocId { get; set; }
		List<string> Keyword { get; set; }
		string FieldName { get; set; }
		bool BreakOnError { get; set; }
		string StoreDialogId { get; set; }
		bool ForceUpdate { get; set; }
    }
}
