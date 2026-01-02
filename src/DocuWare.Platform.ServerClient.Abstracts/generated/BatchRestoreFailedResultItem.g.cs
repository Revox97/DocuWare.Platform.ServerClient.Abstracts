using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreFailedResultItem(DocuWare.Platform.ServerClient.BatchRestoreFailedResultItem obj) : IBatchRestoreFailedResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchRestoreFailedResultItem Obj { get; } = obj;
    }
}
