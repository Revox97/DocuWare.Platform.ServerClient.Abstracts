using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDecisionSettings(SDK.RequestDecisionSettings obj) : IRequestDecisionSettings
    {
        internal SDK.RequestDecisionSettings Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public bool IsActive
        {
            get => Obj.IsActive;
            set => Obj.IsActive = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }
    }
}
