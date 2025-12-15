using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFieldValue(SDK.TaskFieldValue obj) : ITaskFieldValue
    {
        internal SDK.TaskFieldValue Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}

		public ItemChoiceType1 ItemElementName
		{
			get => new temChoiceType1(Obj.ItemElementName);
			set => Obj.ItemElementName = ((temChoiceType1)value).Obj;
		}
    }
}
