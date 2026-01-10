using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteFailedResultItem(DocuWare.Platform.ServerClient.BatchDeleteFailedResultItem obj) : IBatchDeleteFailedResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchDeleteFailedResultItem Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }
    }
}
