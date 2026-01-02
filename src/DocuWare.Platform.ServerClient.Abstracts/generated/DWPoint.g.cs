using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DWPoint(DocuWare.Platform.ServerClient.DWPoint obj) : IDWPoint
    {
        internal DocuWare.Platform.ServerClient.DWPoint Obj { get; } = obj;

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
