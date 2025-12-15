using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AuthenticationServiceCommunicationException(SDK.AuthenticationServiceCommunicationException obj) : IAuthenticationServiceCommunicationException
    {
        internal SDK.AuthenticationServiceCommunicationException Obj { get; } = obj;

		public MethodBase TargetSite => Obj.TargetSite;

		public string Message => Obj.Message;

		public IDictionary Data => Obj.Data;

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
