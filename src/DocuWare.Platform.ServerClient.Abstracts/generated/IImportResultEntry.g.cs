using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportResultEntry{3}
    {
		List<IImportEntryVersion> EntryVersions { get; set; }
		string ErrorMessage { get; set; }
		ImportEntryStatus Status { get; set; }
    }
}
