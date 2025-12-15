using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionCellValue(SDK.SuggestionCellValue obj) : ISuggestionCellValue
    {
        internal SDK.SuggestionCellValue Obj { get; } = obj;

		public IPointAndShootInfo HighlightRectangle
		{
			get => new PointAndShootInfo(Obj.HighlightRectangle);
			set => Obj.HighlightRectangle = ((PointAndShootInfo)value).Obj;
		}

		public string TextFallback
		{
			get => Obj.TextFallback;
			set => Obj.TextFallback = value;
		}

		public Decimal DecimalFallback
		{
			get => Obj.DecimalFallback;
			set => Obj.DecimalFallback = value;
		}

		public bool DecimalFallbackSpecified
		{
			get => Obj.DecimalFallbackSpecified;
			set => Obj.DecimalFallbackSpecified = value;
		}

		public DateTime DateFallback
		{
			get => Obj.DateFallback;
			set => Obj.DateFallback = value;
		}

		public bool DateFallbackSpecified
		{
			get => Obj.DateFallbackSpecified;
			set => Obj.DateFallbackSpecified = value;
		}

		public string ColumnName
		{
			get => Obj.ColumnName;
			set => Obj.ColumnName = value;
		}

		public int RowNumber
		{
			get => Obj.RowNumber;
			set => Obj.RowNumber = value;
		}

		public bool Mapped
		{
			get => Obj.Mapped;
			set => Obj.Mapped = value;
		}

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
