using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AuthenticationServiceCommunicationException(DocuWare.Platform.ServerClient.Exceptions.AuthenticationServiceCommunicationException obj) : IAuthenticationServiceCommunicationException
    {
        internal DocuWare.Platform.ServerClient.Exceptions.AuthenticationServiceCommunicationException Obj { get; } = obj;

        public MethodBase TargetSite => Obj.TargetSite;

        public string Message => Obj.Message;

        public System.Collections.IDictionary Data => Obj.Data;

        public Exception InnerException => Obj.InnerException;

        public string HelpLink
        {
            get => Obj.HelpLink;
            set => Obj.HelpLink = value;
        }

        public string Source
        {
            get => Obj.Source;
            set => Obj.Source = value;
        }

        public int HResult
        {
            get => Obj.HResult;
            set => Obj.HResult = value;
        }

        public string StackTrace => Obj.StackTrace;
    }
}
