using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionValue(DocuWare.Platform.ServerClient.SuggestionValue obj) : ISuggestionValue
    {
        internal DocuWare.Platform.ServerClient.SuggestionValue Obj { get; } = obj;

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
    }
}
