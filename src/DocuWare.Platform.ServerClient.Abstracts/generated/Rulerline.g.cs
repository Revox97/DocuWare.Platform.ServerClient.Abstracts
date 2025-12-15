using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Rulerline(SDK.Rulerline obj) : IRulerline
    {
        internal SDK.Rulerline Obj { get; } = obj;

        public int lineWidth
        {
            get => Obj.lineWidth;
            set => Obj.lineWidth = value;
        }

        public DocuWare.Platform.ServerClient.LineStyle style
        {
            get => Obj.style;
            set => Obj.style = value;
        }

        public int L
        {
            get => Obj.L;
            set => Obj.L = value;
        }

        public int T
        {
            get => Obj.T;
            set => Obj.T = value;
        }

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }

        public int H
        {
            get => Obj.H;
            set => Obj.H = value;
        }
    }
}
