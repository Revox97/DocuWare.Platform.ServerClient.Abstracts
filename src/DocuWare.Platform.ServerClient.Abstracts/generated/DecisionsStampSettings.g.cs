using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionsStampSettings(DocuWare.Platform.ServerClient.DecisionsStampSettings obj) : IDecisionsStampSettings
    {
        internal DocuWare.Platform.ServerClient.DecisionsStampSettings Obj { get; } = obj;

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

        public string InstanceId
        {
            get => Obj.InstanceId;
            set => Obj.InstanceId = value;
        }

        public string TaskId
        {
            get => Obj.TaskId;
            set => Obj.TaskId = value;
        }

        public string ActivityName
        {
            get => Obj.ActivityName;
            set => Obj.ActivityName = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
