using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WFFormFieldValue(SDK.WFFormFieldValue obj) : IWFFormFieldValue
    {
        internal SDK.WFFormFieldValue Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}

		public ItemChoiceType ItemElementName
		{
			get => new temChoiceType(Obj.ItemElementName);
			set => Obj.ItemElementName = ((temChoiceType)value).Obj;
		}
    }
}
