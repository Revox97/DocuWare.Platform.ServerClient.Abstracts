using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputFlags(SDK.InputFlags obj) : IInputFlags
    {
        internal SDK.InputFlags Obj { get; } = obj;

        public bool IsEmail
        {
            get => Obj.IsEmail;
            set => Obj.IsEmail = value;
        }
    }
}
