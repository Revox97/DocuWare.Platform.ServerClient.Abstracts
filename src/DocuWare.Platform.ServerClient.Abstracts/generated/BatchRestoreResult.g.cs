using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreResult(SDK.BatchRestoreResult obj) : IBatchRestoreResult
    {
        internal SDK.BatchRestoreResult Obj { get; } = obj;

        public List<Link> Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IBatchRestoreFailedResultItem> FailedItems
        {
            get => Obj.FailedItems.Select(x => new BatchRestoreFailedResultItem(x) as IBatchRestoreFailedResultItem).ToList();
            set => Obj.FailedItems = value.Select(x => ((BatchRestoreFailedResultItem)x).Obj).ToList();
        }

        public int SuccessCount
        {
            get => Obj.SuccessCount;
            set => Obj.SuccessCount = value;
        }
    }
}
