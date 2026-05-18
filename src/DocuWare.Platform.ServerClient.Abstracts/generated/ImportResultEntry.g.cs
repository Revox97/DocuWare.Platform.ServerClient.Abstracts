using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportResultEntry(SDK.ImportResultEntry obj) : IImportResultEntry
    {
        internal SDK.ImportResultEntry Obj { get; } = obj;

        public List<IImportEntryVersion> EntryVersions
        {
            get => Obj.EntryVersions.Select(x => new ImportEntryVersion(x) as IImportEntryVersion).ToList();
            set => Obj.EntryVersions = value.Select(x => ((ImportEntryVersion)x).Obj).ToList();
        }

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }

        public ImportEntryStatus Status
        {
            get => (ImportEntryStatus)Obj.Status;
            set => Obj.Status = (DocuWare.Platform.ServerClient.ImportEntryStatus)value;
        }
    }
}
