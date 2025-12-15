using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SizedAnnotationToolSettings(SDK.SizedAnnotationToolSettings obj) : ISizedAnnotationToolSettings
    {
        internal SDK.SizedAnnotationToolSettings Obj { get; } = obj;

        public int LineSize
        {
            get => Obj.LineSize;
            set => Obj.LineSize = value;
        }

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
