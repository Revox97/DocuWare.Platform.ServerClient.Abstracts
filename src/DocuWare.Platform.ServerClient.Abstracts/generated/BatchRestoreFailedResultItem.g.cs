using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchRestoreFailedResultItem(SDK.BatchRestoreFailedResultItem obj) : IBatchRestoreFailedResultItem
    {
        internal SDK.BatchRestoreFailedResultItem Obj { get; } = obj;

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
