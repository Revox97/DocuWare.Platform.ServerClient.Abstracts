using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignedItem(SDK.AssignedItem obj) : IAssignedItem
    {
        internal SDK.AssignedItem Obj { get; } = obj;

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
