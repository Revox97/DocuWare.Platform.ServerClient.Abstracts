using SDK = DocuWare.Platform.ServerClient;

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
