using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportEntryVersion
    {
		int Id { get; set; }
		DocuWare.Platform.ServerClient.ImportEntryVersionStatus Status { get; set; }
    }
}
