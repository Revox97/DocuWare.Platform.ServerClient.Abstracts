using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ClientThrottleException(SDK.ClientThrottleException obj) : IClientThrottleException
    {
        internal SDK.ClientThrottleException Obj { get; } = obj;

		public TimeSpan RetryAfterInterval => Obj.RetryAfterInterval;

		public string Message => Obj.Message;

		public MethodBase TargetSite => Obj.TargetSite;

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
