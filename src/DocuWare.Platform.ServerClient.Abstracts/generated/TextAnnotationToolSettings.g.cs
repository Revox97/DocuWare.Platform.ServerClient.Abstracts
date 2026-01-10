using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextAnnotationToolSettings(DocuWare.Platform.ServerClient.WebClient.TextAnnotationToolSettings obj) : ITextAnnotationToolSettings
    {
        internal DocuWare.Platform.ServerClient.WebClient.TextAnnotationToolSettings Obj { get; } = obj;

        public IFontSettings FontSettings
        {
            get => new FontSettings(Obj.FontSettings);
            set => Obj.FontSettings = ((FontSettings)value).Obj;
        }

        public AnnotationTools Type
        {
            get => (AnnotationTools)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.WebClient.AnnotationTools)value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }
    }
}
