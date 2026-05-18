using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportEntryVersion(SDK.ImportEntryVersion obj) : IImportEntryVersion
    {
        internal SDK.ImportEntryVersion Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public ImportEntryVersionStatus Status
        {
            get => (ImportEntryVersionStatus)Obj.Status;
            set => Obj.Status = (DocuWare.Platform.ServerClient.ImportEntryVersionStatus)value;
        }
    }
}
