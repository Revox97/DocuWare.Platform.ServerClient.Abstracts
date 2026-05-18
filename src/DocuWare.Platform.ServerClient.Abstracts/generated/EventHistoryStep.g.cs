using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EventHistoryStep(DocuWare.Platform.ServerClient.EventHistoryStep obj) : IEventHistoryStep
    {
        internal DocuWare.Platform.ServerClient.EventHistoryStep Obj { get; } = obj;

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
