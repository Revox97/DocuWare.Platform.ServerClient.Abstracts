using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StrokeStamp(SDK.StrokeStamp obj) : IStrokeStamp
    {
        internal SDK.StrokeStamp Obj { get; } = obj;

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
