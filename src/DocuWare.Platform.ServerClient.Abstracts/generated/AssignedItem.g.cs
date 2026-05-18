using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
            get => (AssignedItemTypeEnum)Obj.ItemType;
            set => Obj.ItemType = (DocuWare.Platform.ServerClient.AssignedItemTypeEnum)value;
        }
    }
}
