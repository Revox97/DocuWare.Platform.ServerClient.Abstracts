using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionValue(SDK.SuggestionValue obj) : ISuggestionValue
    {
        internal SDK.SuggestionValue Obj { get; } = obj;

		public IPointAndShootInfo Source
		{
			get => new PointAndShootInfo(Obj.Source);
			set => Obj.Source = ((PointAndShootInfo)value).Obj;
		}

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
