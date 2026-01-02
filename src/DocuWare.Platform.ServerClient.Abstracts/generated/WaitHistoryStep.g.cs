using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WaitHistoryStep(DocuWare.Platform.ServerClient.WaitHistoryStep obj) : IWaitHistoryStep
    {
        internal DocuWare.Platform.ServerClient.WaitHistoryStep Obj { get; } = obj;

        public List<IConditionHistoryStep> Conditions
        {
            get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
            set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
        }

        public string Status
        {
            get => Obj.Status;
            set => Obj.Status = value;
        }
    }
}
