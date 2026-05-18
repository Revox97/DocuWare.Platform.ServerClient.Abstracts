using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EventHistoryStep(SDK.EventHistoryStep obj) : IEventHistoryStep
    {
        internal SDK.EventHistoryStep Obj { get; } = obj;

        public List<IConditionHistoryStep> Conditions
        {
            get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
            set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
        }

        public string FCName
        {
            get => Obj.FCName;
            set => Obj.FCName = value;
        }

        public string DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string Status
        {
            get => Obj.Status;
            set => Obj.Status = value;
        }
    }
}
