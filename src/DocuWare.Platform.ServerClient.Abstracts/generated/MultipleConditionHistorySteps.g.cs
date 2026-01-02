using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultipleConditionHistorySteps(DocuWare.Platform.ServerClient.MultipleConditionHistorySteps obj) : IMultipleConditionHistorySteps
    {
        internal DocuWare.Platform.ServerClient.MultipleConditionHistorySteps Obj { get; } = obj;

        public List<IConditionHistoryStep> Conditions
        {
            get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
            set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
        }
    }
}
