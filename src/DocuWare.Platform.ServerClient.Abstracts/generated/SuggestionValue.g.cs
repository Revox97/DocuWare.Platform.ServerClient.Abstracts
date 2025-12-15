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

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }

        public DocuWare.Platform.ServerClient.ItemChoiceType ItemElementName
        {
            get => Obj.ItemElementName;
            set => Obj.ItemElementName = value;
        }
    }
}
