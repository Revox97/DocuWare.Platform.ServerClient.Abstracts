using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignedItem(DocuWare.Platform.ServerClient.AssignedItem obj) : IAssignedItem
    {
        internal DocuWare.Platform.ServerClient.AssignedItem Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public DocuWare.Platform.ServerClient.AssignedItemTypeEnum ItemType
        {
            get => Obj.ItemType;
            set => Obj.ItemType = value;
        }
    }
}
