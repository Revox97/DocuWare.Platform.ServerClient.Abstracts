using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialog : IDialogInfo
    {
		List<IDialogField> Fields { get; set; }
		bool HasValidation { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
