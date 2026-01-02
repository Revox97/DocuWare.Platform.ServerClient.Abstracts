using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteResult(DocuWare.Platform.ServerClient.BatchDeleteResult obj) : IBatchDeleteResult
    {
        internal DocuWare.Platform.ServerClient.BatchDeleteResult Obj { get; } = obj;

        public List<Link> Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IBatchDeleteFailedResultItem> FailedItems
        {
            get => Obj.FailedItems.Select(x => new BatchDeleteFailedResultItem(x) as IBatchDeleteFailedResultItem).ToList();
            set => Obj.FailedItems = value.Select(x => ((BatchDeleteFailedResultItem)x).Obj).ToList();
        }

        public int SuccessCount
        {
            get => Obj.SuccessCount;
            set => Obj.SuccessCount = value;
        }
    }
}
