using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionHistoryStep(DocuWare.Platform.ServerClient.DecisionHistoryStep obj) : IDecisionHistoryStep
    {
        internal DocuWare.Platform.ServerClient.DecisionHistoryStep Obj { get; } = obj;

        public List<IHistoryField> InputFields
        {
            get => Obj.InputFields.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.InputFields = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public List<IHistoryField> Assignments
        {
            get => Obj.Assignments.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.Assignments = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public List<IFileCabinetHistoryField> FileCabinetAssignments
        {
            get => Obj.FileCabinetAssignments.Select(x => new FileCabinetHistoryField(x) as IFileCabinetHistoryField).ToList();
            set => Obj.FileCabinetAssignments = value.Select(x => ((FileCabinetHistoryField)x).Obj).ToList();
        }

        public List<IConditionHistoryStep> Conditions
        {
            get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
            set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
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
