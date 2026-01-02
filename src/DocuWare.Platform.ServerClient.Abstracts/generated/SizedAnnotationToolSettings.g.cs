using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SizedAnnotationToolSettings(DocuWare.Platform.ServerClient.WebClient.SizedAnnotationToolSettings obj) : ISizedAnnotationToolSettings
    {
        internal DocuWare.Platform.ServerClient.WebClient.SizedAnnotationToolSettings Obj { get; } = obj;

        public int LineSize
        {
            get => Obj.LineSize;
            set => Obj.LineSize = value;
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
