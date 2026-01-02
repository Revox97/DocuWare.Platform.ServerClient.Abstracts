using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportResultEntry(DocuWare.Platform.ServerClient.ImportResultEntry obj) : IImportResultEntry
    {
        internal DocuWare.Platform.ServerClient.ImportResultEntry Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.ImportEntryStatus Status
        {
            get => Obj.Status;
            set => Obj.Status = value;
        }
    }
}
