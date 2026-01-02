using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationToolSettings(DocuWare.Platform.ServerClient.WebClient.AnnotationToolSettings obj) : IAnnotationToolSettings
    {
        internal DocuWare.Platform.ServerClient.WebClient.AnnotationToolSettings Obj { get; } = obj;

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
