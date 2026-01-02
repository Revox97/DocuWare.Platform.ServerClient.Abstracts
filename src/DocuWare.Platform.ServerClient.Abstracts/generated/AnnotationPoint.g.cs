using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationPoint(DocuWare.Platform.ServerClient.AnnotationPoint obj) : IAnnotationPoint
    {
        internal DocuWare.Platform.ServerClient.AnnotationPoint Obj { get; } = obj;

        public double X
        {
            get => Obj.X;
            set => Obj.X = value;
        }

        public double Y
        {
            get => Obj.Y;
            set => Obj.Y = value;
        }
    }
}
