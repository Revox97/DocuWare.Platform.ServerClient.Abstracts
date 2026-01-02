using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationToolSettings(DocuWare.Platform.ServerClient.WebClient.AnnotationToolSettings obj) : IAnnotationToolSettings
    {
        internal DocuWare.Platform.ServerClient.WebClient.AnnotationToolSettings Obj { get; } = obj;

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
