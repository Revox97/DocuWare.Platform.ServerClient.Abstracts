using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class Rulerline(SDK.Content.Rulerline obj) : IRulerline
    {
        internal SDK.Content.Rulerline Obj { get; } = obj;

        public int lineWidth
        {
            get => Obj.lineWidth;
            set => Obj.lineWidth = value;
        }

        public LineStyle style
        {
            get => (LineStyle)Obj.style;
            set => Obj.style = (DocuWare.Platform.ServerClient.Content.LineStyle)value;
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
