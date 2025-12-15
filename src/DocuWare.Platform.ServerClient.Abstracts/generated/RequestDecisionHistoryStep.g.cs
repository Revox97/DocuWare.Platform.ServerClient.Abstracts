using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDecisionHistoryStep(SDK.RequestDecisionHistoryStep obj) : IRequestDecisionHistoryStep
    {
        internal SDK.RequestDecisionHistoryStep Obj { get; } = obj;

        public List<IHistoryField> InputFields
        {
            get => Obj.InputFields.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.InputFields = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public string DocumentUserVersion
        {
            get => Obj.DocumentUserVersion;
            set => Obj.DocumentUserVersion = value;
        }

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public string DecisionName
        {
            get => Obj.DecisionName;
            set => Obj.DecisionName = value;
        }

        public DateTime DecisionDate
        {
            get => Obj.DecisionDate;
            set => Obj.DecisionDate = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }
    }
}
