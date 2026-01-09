using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesResultList : IDialogProperties
    {
		List<IResultDialogFunction> Functions { get; set; }
		List<ISortedField> SortOrder { get; set; }
		LetterCase DefaultListTextLetterCase { get; set; }
		bool DisplayFirstDocument { get; set; }
		bool ShowCheckedOutDocumens { get; set; }
    }
}
