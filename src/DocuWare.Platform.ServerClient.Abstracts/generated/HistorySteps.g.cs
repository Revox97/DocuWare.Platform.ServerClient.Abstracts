using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistorySteps(SDK.HistorySteps obj) : IHistorySteps
    {
        internal SDK.HistorySteps Obj { get; } = obj;

        public List<IHistoryStep> HistoryStep
        {
            get => Obj.HistoryStep.Select(x => new HistoryStep(x) as IHistoryStep).ToList();
            set => Obj.HistoryStep = value.Select(x => ((HistoryStep)x).Obj).ToList();
        }
    }
}
