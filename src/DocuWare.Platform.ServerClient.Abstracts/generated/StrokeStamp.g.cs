using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StrokeStamp(DocuWare.Platform.ServerClient.StrokeStamp obj) : IStrokeStamp
    {
        internal DocuWare.Platform.ServerClient.StrokeStamp Obj { get; } = obj;

        public uint StrokeWidth
        {
            get => Obj.StrokeWidth;
            set => Obj.StrokeWidth = value;
        }

        public string StrokeColor
        {
            get => Obj.StrokeColor;
            set => Obj.StrokeColor = value;
        }
    }
}
