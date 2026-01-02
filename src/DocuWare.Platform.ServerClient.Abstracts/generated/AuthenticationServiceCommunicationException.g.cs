using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AuthenticationServiceCommunicationException(DocuWare.Platform.ServerClient.Exceptions.AuthenticationServiceCommunicationException obj) : IAuthenticationServiceCommunicationException
    {
        internal DocuWare.Platform.ServerClient.Exceptions.AuthenticationServiceCommunicationException Obj { get; } = obj;

        public string Message => Obj.Message;

        public IDictionary Data => Obj.Data;
    }
}
