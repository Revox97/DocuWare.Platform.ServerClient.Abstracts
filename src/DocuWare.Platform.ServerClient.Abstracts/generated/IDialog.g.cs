using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialog : IDialogInfo
    {
		List<IDialogField> Fields { get; set; }
		IDocumentsQuery Query { get; set; }
		IDialogProperties Properties { get; set; }
		IIntellixFieldAssignments IntellixFieldAssignments { get; set; }
		bool HasValidation { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
