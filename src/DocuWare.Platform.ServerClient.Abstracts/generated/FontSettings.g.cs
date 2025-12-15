using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FontSettings(SDK.FontSettings obj) : IFontSettings
    {
        internal SDK.FontSettings Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string Size
		{
			get => Obj.Size;
			set => Obj.Size = value;
		}

		public bool Bold
		{
			get => Obj.Bold;
			set => Obj.Bold = value;
		}

		public bool Italic
		{
			get => Obj.Italic;
			set => Obj.Italic = value;
		}

		public bool Underline
		{
			get => Obj.Underline;
			set => Obj.Underline = value;
		}

		public bool Strikeout
		{
			get => Obj.Strikeout;
			set => Obj.Strikeout = value;
		}
    }
}
