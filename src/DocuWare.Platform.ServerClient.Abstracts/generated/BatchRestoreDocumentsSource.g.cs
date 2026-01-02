using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreDocumentsSource(DocuWare.Platform.ServerClient.BatchRestoreDocumentsSource obj) : IBatchRestoreDocumentsSource
    {
        internal DocuWare.Platform.ServerClient.BatchRestoreDocumentsSource Obj { get; } = obj;

        public List<string> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
