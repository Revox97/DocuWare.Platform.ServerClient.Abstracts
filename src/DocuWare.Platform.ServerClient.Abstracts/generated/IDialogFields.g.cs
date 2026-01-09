using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogFields{3}
    {
		List<IDialogField> Field { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
