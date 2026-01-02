using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TimeoutHistoryStep(DocuWare.Platform.ServerClient.TimeoutHistoryStep obj) : ITimeoutHistoryStep
    {
        internal DocuWare.Platform.ServerClient.TimeoutHistoryStep Obj { get; } = obj;

        public string OutputName
        {
            get => Obj.OutputName;
            set => Obj.OutputName = value;
        }
    }
}
