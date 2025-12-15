using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConditionHistoryStep(SDK.ConditionHistoryStep obj) : IConditionHistoryStep
    {
        internal SDK.ConditionHistoryStep Obj { get; } = obj;

        public string OutputName
        {
            get => Obj.OutputName;
            set => Obj.OutputName = value;
        }

        public bool Taken
        {
            get => Obj.Taken;
            set => Obj.Taken = value;
        }
    }
}
