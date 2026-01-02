using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteFailedResultItem(SDK.BatchDeleteFailedResultItem obj) : IBatchDeleteFailedResultItem
    {
        internal SDK.BatchDeleteFailedResultItem Obj { get; } = obj;
    }
}
