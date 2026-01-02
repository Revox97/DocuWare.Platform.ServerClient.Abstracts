using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Font(DocuWare.Platform.ServerClient.Font obj) : IFont
    {
        internal DocuWare.Platform.ServerClient.Font Obj { get; } = obj;

        public string FontName
        {
            get => Obj.FontName;
            set => Obj.FontName = value;
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

        public bool Underlined
        {
            get => Obj.Underlined;
            set => Obj.Underlined = value;
        }

        public bool StrikeThrough
        {
            get => Obj.StrikeThrough;
            set => Obj.StrikeThrough = value;
        }

        public int FontSize
        {
            get => Obj.FontSize;
            set => Obj.FontSize = value;
        }

        public int Spacing
        {
            get => Obj.Spacing;
            set => Obj.Spacing = value;
        }
    }
}
