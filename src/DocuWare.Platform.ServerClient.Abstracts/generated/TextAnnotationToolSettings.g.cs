using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextAnnotationToolSettings(SDK.TextAnnotationToolSettings obj) : ITextAnnotationToolSettings
    {
        internal SDK.TextAnnotationToolSettings Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.AnnotationTools Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }
    }
}
