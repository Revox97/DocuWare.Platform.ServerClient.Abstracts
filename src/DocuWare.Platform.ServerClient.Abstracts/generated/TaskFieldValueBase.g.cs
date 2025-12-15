using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFieldValueBase(SDK.TaskFieldValueBase obj) : ITaskFieldValueBase
    {
        internal SDK.TaskFieldValueBase Obj { get; } = obj;

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
