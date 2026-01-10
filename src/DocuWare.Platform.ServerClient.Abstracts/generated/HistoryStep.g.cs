using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStep(DocuWare.Platform.ServerClient.HistoryStep obj) : IHistoryStep
    {
        internal DocuWare.Platform.ServerClient.HistoryStep Obj { get; } = obj;

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
