using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteDocumentsSource(DocuWare.Platform.ServerClient.BatchDeleteDocumentsSource obj) : IBatchDeleteDocumentsSource
    {
        internal DocuWare.Platform.ServerClient.BatchDeleteDocumentsSource Obj { get; } = obj;

        public List<string> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
