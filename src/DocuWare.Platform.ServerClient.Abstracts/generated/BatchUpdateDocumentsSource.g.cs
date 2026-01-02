using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDocumentsSource(DocuWare.Platform.ServerClient.BatchUpdateDocumentsSource obj) : IBatchUpdateDocumentsSource
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateDocumentsSource Obj { get; } = obj;

        public List<int> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
