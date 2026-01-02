using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteFailedResultItem(DocuWare.Platform.ServerClient.BatchDeleteFailedResultItem obj) : IBatchDeleteFailedResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchDeleteFailedResultItem Obj { get; } = obj;
    }
}
