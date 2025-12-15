using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesResultList
    {
		List<IResultDialogFunction> Functions { get; set; }
		IViewerDialog ViewerDialog { get; set; }
		List<ISortedField> SortOrder { get; set; }
		DocuWare.Platform.ServerClient.LetterCase DefaultListTextLetterCase { get; set; }
		bool DisplayFirstDocument { get; set; }
		bool ShowCheckedOutDocumens { get; set; }
    }
}
