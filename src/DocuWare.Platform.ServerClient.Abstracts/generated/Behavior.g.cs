using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Behavior(DocuWare.Platform.ServerClient.Behavior obj) : IBehavior
    {
        internal DocuWare.Platform.ServerClient.Behavior Obj { get; } = obj;

        public List<IBehaviorCondition> Conditions
        {
            get => Obj.Conditions.Select(x => new BehaviorCondition(x) as IBehaviorCondition).ToList();
            set => Obj.Conditions = value.Select(x => ((BehaviorCondition)x).Obj).ToList();
        }

        public List<IBehaviorAction> PassActions
        {
            get => Obj.PassActions.Select(x => new BehaviorAction(x) as IBehaviorAction).ToList();
            set => Obj.PassActions = value.Select(x => ((BehaviorAction)x).Obj).ToList();
        }

        public List<IBehaviorAction> FailActions
        {
            get => Obj.FailActions.Select(x => new BehaviorAction(x) as IBehaviorAction).ToList();
            set => Obj.FailActions = value.Select(x => ((BehaviorAction)x).Obj).ToList();
        }
    }
}
