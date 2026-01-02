using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeneralErrorDecisionHistoryStep(DocuWare.Platform.ServerClient.GeneralErrorDecisionHistoryStep obj) : IGeneralErrorDecisionHistoryStep
    {
        internal DocuWare.Platform.ServerClient.GeneralErrorDecisionHistoryStep Obj { get; } = obj;

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
