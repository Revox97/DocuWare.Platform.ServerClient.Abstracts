using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistorySteps(DocuWare.Platform.ServerClient.HistorySteps obj) : IHistorySteps
    {
        internal DocuWare.Platform.ServerClient.HistorySteps Obj { get; } = obj;

        public List<IHistoryStep> HistoryStep
        {
            get => Obj.HistoryStep.Select(x => new HistoryStep(x) as IHistoryStep).ToList();
            set => Obj.HistoryStep = value.Select(x => ((HistoryStep)x).Obj).ToList();
        }
    }
}
