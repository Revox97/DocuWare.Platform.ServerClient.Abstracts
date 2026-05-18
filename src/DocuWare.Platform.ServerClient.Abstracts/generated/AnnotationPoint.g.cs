using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationPoint(SDK.AnnotationPoint obj) : IAnnotationPoint
    {
        internal SDK.AnnotationPoint Obj { get; } = obj;

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
