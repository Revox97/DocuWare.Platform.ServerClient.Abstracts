using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextAnnotationToolSettings(SDK.TextAnnotationToolSettings obj) : ITextAnnotationToolSettings
    {
        internal SDK.TextAnnotationToolSettings Obj { get; } = obj;

		public IFontSettings FontSettings
		{
			get => new FontSettings(Obj.FontSettings);
			set => Obj.FontSettings = ((FontSettings)value).Obj;
		}

		public AnnotationTools Type
		{
			get => new nnotationTools(Obj.Type);
			set => Obj.Type = ((nnotationTools)value).Obj;
		}

		public string Color
		{
			get => Obj.Color;
			set => Obj.Color = value;
		}
    }
}
