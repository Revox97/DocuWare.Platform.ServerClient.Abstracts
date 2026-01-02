using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AuthenticationServiceCommunicationException(SDK.AuthenticationServiceCommunicationException obj) : IAuthenticationServiceCommunicationException
    {
        internal SDK.AuthenticationServiceCommunicationException Obj { get; } = obj;

        public string Message => Obj.Message;

        public IDictionary Data => Obj.Data;
    }
}
