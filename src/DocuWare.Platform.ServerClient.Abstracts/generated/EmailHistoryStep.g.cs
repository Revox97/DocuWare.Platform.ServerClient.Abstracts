using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EmailHistoryStep(SDK.EmailHistoryStep obj) : IEmailHistoryStep
    {
        internal SDK.EmailHistoryStep Obj { get; } = obj;

        public List<string> Recipients
        {
            get => Obj.Recipients;
            set => Obj.Recipients = value;
        }

        public List<string> Cc
        {
            get => Obj.Cc;
            set => Obj.Cc = value;
        }

        public List<IConditionHistoryStep> Conditions
        {
            get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
            set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
        }

        public string Subject
        {
            get => Obj.Subject;
            set => Obj.Subject = value;
        }
    }
}
