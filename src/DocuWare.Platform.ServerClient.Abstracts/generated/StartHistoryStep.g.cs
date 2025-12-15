using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StartHistoryStep(SDK.StartHistoryStep obj) : IStartHistoryStep
    {
        internal SDK.StartHistoryStep Obj { get; } = obj;

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
    }
}
