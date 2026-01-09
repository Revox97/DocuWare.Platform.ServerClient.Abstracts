using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogTableFieldColumns
    {
		List<IDialogFieldBase> DialogTableFieldColumn { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
