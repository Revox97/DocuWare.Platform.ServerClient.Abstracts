using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Zone(SDK.Zone obj) : IZone
    {
        internal SDK.Zone Obj { get; } = obj;

		public int ZoneID
		{
			get => Obj.ZoneID;
			set => Obj.ZoneID = value;
		}

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public int PageNumber
		{
			get => Obj.PageNumber;
			set => Obj.PageNumber = value;
		}

		public int X
		{
			get => Obj.X;
			set => Obj.X = value;
		}

		public int Y
		{
			get => Obj.Y;
			set => Obj.Y = value;
		}

		public int W
		{
			get => Obj.W;
			set => Obj.W = value;
		}

		public int H
		{
			get => Obj.H;
			set => Obj.H = value;
		}

		public string MappedWebFormFieldName
		{
			get => Obj.MappedWebFormFieldName;
			set => Obj.MappedWebFormFieldName = value;
		}

		public string MappedWebFormFieldType
		{
			get => Obj.MappedWebFormFieldType;
			set => Obj.MappedWebFormFieldType = value;
		}

		public string FillAreaName
		{
			get => Obj.FillAreaName;
			set => Obj.FillAreaName = value;
		}

		public string SampleText
		{
			get => Obj.SampleText;
			set => Obj.SampleText = value;
		}

		public string FontType
		{
			get => Obj.FontType;
			set => Obj.FontType = value;
		}

		public int FontSize
		{
			get => Obj.FontSize;
			set => Obj.FontSize = value;
		}

		public string FontColor
		{
			get => Obj.FontColor;
			set => Obj.FontColor = value;
		}

		public bool FontWeightBold
		{
			get => Obj.FontWeightBold;
			set => Obj.FontWeightBold = value;
		}

		public bool FontWeightItalic
		{
			get => Obj.FontWeightItalic;
			set => Obj.FontWeightItalic = value;
		}

		public bool FontWeightUnderlined
		{
			get => Obj.FontWeightUnderlined;
			set => Obj.FontWeightUnderlined = value;
		}

		public AlignmentType TextAlignment
		{
			get => new lignmentType(Obj.TextAlignment);
			set => Obj.TextAlignment = ((lignmentType)value).Obj;
		}

		public int OriginalImageWidth
		{
			get => Obj.OriginalImageWidth;
			set => Obj.OriginalImageWidth = value;
		}

		public bool WrapText
		{
			get => Obj.WrapText;
			set => Obj.WrapText = value;
		}
    }
}
