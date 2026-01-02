using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationRectangle(DocuWare.Platform.ServerClient.AnnotationRectangle obj) : IAnnotationRectangle
    {
        internal DocuWare.Platform.ServerClient.AnnotationRectangle Obj { get; } = obj;

        public double Left
        {
            get => Obj.Left;
            set => Obj.Left = value;
        }

        public double Top
        {
            get => Obj.Top;
            set => Obj.Top = value;
        }

        public double Width
        {
            get => Obj.Width;
            set => Obj.Width = value;
        }

        public double Height
        {
            get => Obj.Height;
            set => Obj.Height = value;
        }
    }
}
