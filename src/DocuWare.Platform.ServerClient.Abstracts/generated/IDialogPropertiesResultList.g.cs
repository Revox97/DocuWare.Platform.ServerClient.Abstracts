using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesResultList : IDialogProperties
    {
		List<IResultDialogFunction> Functions { get; set; }
		IViewerDialog ViewerDialog { get; set; }
		List<ISortedField> SortOrder { get; set; }
		LetterCase DefaultListTextLetterCase { get; set; }
		bool DisplayFirstDocument { get; set; }
		bool ShowCheckedOutDocumens { get; set; }
    }
}
