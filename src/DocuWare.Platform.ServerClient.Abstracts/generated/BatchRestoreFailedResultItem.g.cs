using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreFailedResultItem(DocuWare.Platform.ServerClient.BatchRestoreFailedResultItem obj) : IBatchRestoreFailedResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchRestoreFailedResultItem Obj { get; } = obj;

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
