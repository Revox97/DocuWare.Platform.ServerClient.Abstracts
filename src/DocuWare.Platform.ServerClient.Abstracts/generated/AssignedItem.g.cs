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

		public AssignedItemTypeEnum ItemType
		{
			get => new ssignedItemTypeEnum(Obj.ItemType);
			set => Obj.ItemType = ((ssignedItemTypeEnum)value).Obj;
		}
    }
}
