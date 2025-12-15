using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesTaskList
    {
		IDialogExpression Conditions { get; set; }
		string ConditionString { get; set; }
		bool Private { get; set; }
		bool AutoRefresh { get; set; }
		int AutoRefreshPeriod { get; set; }
		bool AutoRefreshPeriodSpecified { get; set; }
		List<IResultDialogFunction> Functions { get; set; }
		IViewerDialog ViewerDialog { get; set; }
		List<ISortedField> SortOrder { get; set; }
		DocuWare.Platform.ServerClient.LetterCase DefaultListTextLetterCase { get; set; }
		bool DisplayFirstDocument { get; set; }
		bool ShowCheckedOutDocumens { get; set; }
    }
}
