using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesTaskList
    {
		string ConditionString { get; set; }
		bool Private { get; set; }
		bool AutoRefresh { get; set; }
		int AutoRefreshPeriod { get; set; }
		List<IResultDialogFunction> Functions { get; set; }
		List<ISortedField> SortOrder { get; set; }
		LetterCase DefaultListTextLetterCase { get; set; }
		bool DisplayFirstDocument { get; set; }
		bool ShowCheckedOutDocumens { get; set; }
    }
}
