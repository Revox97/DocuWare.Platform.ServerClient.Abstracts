using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserValidation(SDK.UserValidation obj) : IUserValidation
    {
        internal SDK.UserValidation Obj { get; } = obj;

        public string Password
        {
            get => Obj.Password;
            set => Obj.Password = value;
        }
    }
}
