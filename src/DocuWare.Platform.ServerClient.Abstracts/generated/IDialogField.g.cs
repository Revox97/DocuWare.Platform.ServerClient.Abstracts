using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogField : IDialogFieldBase
    {
		List<IDialogFieldBase> DialogTableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }
		bool IsHierarchy { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
