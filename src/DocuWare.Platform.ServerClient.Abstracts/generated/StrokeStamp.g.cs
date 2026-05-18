using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
