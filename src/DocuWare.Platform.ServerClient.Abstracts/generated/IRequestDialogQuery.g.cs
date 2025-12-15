using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDialogQuery
    {
		List<DocuWare.Platform.ServerClient.DialogTypes> DialogTypes { get; set; }
    }
}
