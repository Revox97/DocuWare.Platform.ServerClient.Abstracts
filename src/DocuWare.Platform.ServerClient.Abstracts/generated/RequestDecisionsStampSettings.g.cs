using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDecisionsStampSettings(SDK.RequestDecisionsStampSettings obj) : IRequestDecisionsStampSettings
    {
        internal SDK.RequestDecisionsStampSettings Obj { get; } = obj;

        public IWorkflowStampsSettings StampsSettings
        {
            get => new WorkflowStampsSettings(Obj.StampsSettings);
            set => Obj.StampsSettings = ((WorkflowStampsSettings)value).Obj;
        }

        public List<IDecision> DecisionStamps
        {
            get => Obj.DecisionStamps.Select(x => new Decision(x) as IDecision).ToList();
            set => Obj.DecisionStamps = value.Select(x => ((Decision)x).Obj).ToList();
        }

        public string WorkflowId
        {
            get => Obj.WorkflowId;
            set => Obj.WorkflowId = value;
        }

        public string TaskId
        {
            get => Obj.TaskId;
            set => Obj.TaskId = value;
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
