using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDialogQuery
    {
		List<DialogTypes> DialogTypes { get; set; }
    }
}
