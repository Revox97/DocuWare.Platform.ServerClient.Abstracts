using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionTable(DocuWare.Platform.ServerClient.SuggestionTable obj) : ISuggestionTable
    {
        internal DocuWare.Platform.ServerClient.SuggestionTable Obj { get; } = obj;

        public List<ISuggestionCellValue> Cell
        {
            get => Obj.Cell.Select(x => new SuggestionCellValue(x) as ISuggestionCellValue).ToList();
            set => Obj.Cell = value.Select(x => ((SuggestionCellValue)x).Obj).ToList();
        }

        public List<IPointAndShootInfo> HighlightRectangle
        {
            get => Obj.HighlightRectangle.Select(x => new PointAndShootInfo(x) as IPointAndShootInfo).ToList();
            set => Obj.HighlightRectangle = value.Select(x => ((PointAndShootInfo)x).Obj).ToList();
        }

        public double Trust
        {
            get => Obj.Trust;
            set => Obj.Trust = value;
        }
    }
}
