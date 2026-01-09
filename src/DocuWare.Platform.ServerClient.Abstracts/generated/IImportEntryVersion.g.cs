using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportEntryVersion{3}
    {
		int Id { get; set; }
		ImportEntryVersionStatus Status { get; set; }
    }
}
