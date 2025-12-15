using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TimeoutHistoryStep(SDK.TimeoutHistoryStep obj) : ITimeoutHistoryStep
    {
        internal SDK.TimeoutHistoryStep Obj { get; } = obj;

		public string OutputName
		{
			get => Obj.OutputName;
			set => Obj.OutputName = value;
		}
    }
}
