using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignDataHistoryStep(SDK.AssignDataHistoryStep obj) : IAssignDataHistoryStep
    {
        internal SDK.AssignDataHistoryStep Obj { get; } = obj;

		public List<IHistoryField> Fields
		{
			get => Obj.Fields.Select(x => new HistoryField(x) as IHistoryField).ToList();
			set => Obj.Fields = value.Select(x => ((HistoryField)x).Obj).ToList();
		}

		public List<IFileCabinetHistoryField> FileCabinetFields
		{
			get => Obj.FileCabinetFields.Select(x => new FileCabinetHistoryField(x) as IFileCabinetHistoryField).ToList();
			set => Obj.FileCabinetFields = value.Select(x => ((FileCabinetHistoryField)x).Obj).ToList();
		}

		public List<IConditionHistoryStep> Conditions
		{
			get => Obj.Conditions.Select(x => new ConditionHistoryStep(x) as IConditionHistoryStep).ToList();
			set => Obj.Conditions = value.Select(x => ((ConditionHistoryStep)x).Obj).ToList();
		}
    }
}
