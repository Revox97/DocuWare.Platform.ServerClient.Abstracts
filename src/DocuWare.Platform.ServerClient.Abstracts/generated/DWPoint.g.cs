using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DWPoint(SDK.DWPoint obj) : IDWPoint
    {
        internal SDK.DWPoint Obj { get; } = obj;

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
