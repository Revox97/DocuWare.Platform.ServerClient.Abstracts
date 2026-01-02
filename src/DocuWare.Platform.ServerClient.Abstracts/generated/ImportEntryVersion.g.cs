using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportEntryVersion(DocuWare.Platform.ServerClient.ImportEntryVersion obj) : IImportEntryVersion
    {
        internal DocuWare.Platform.ServerClient.ImportEntryVersion Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public DocuWare.Platform.ServerClient.ImportEntryVersionStatus Status
        {
            get => Obj.Status;
            set => Obj.Status = value;
        }
    }
}
