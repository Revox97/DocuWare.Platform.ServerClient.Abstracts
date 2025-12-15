using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreDocumentsSource(SDK.BatchRestoreDocumentsSource obj) : IBatchRestoreDocumentsSource
    {
        internal SDK.BatchRestoreDocumentsSource Obj { get; } = obj;

        public List<string> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
