using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreFailedResultItem(SDK.BatchRestoreFailedResultItem obj) : IBatchRestoreFailedResultItem
    {
        internal SDK.BatchRestoreFailedResultItem Obj { get; } = obj;
    }
}
