using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeneralErrorDecisionHistoryStep(SDK.GeneralErrorDecisionHistoryStep obj) : IGeneralErrorDecisionHistoryStep
    {
        internal SDK.GeneralErrorDecisionHistoryStep Obj { get; } = obj;

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
    }
}
