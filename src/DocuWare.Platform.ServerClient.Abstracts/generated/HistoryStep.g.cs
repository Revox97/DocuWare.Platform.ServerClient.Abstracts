using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStep(SDK.HistoryStep obj) : IHistoryStep
    {
        internal SDK.HistoryStep Obj { get; } = obj;

        public IHistoryStepInfo Info
        {
            get => new HistoryStepInfo(Obj.Info);
            set => Obj.Info = ((HistoryStepInfo)value).Obj;
        }

        public int StepNumber
        {
            get => Obj.StepNumber;
            set => Obj.StepNumber = value;
        }

        public DateTime StepDate
        {
            get => Obj.StepDate;
            set => Obj.StepDate = value;
        }

        public string ActivityName
        {
            get => Obj.ActivityName;
            set => Obj.ActivityName = value;
        }

        public string ActivityType
        {
            get => Obj.ActivityType;
            set => Obj.ActivityType = value;
        }

        public StepTypeEnum StepType
        {
            get => (StepTypeEnum)Obj.StepType;
            set => Obj.StepType = (DocuWare.Platform.ServerClient.StepTypeEnum)value;
        }
    }
}
