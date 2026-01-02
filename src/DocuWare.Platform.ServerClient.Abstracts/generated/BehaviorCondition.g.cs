using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BehaviorCondition(SDK.BehaviorCondition obj) : IBehaviorCondition
    {
        internal SDK.BehaviorCondition Obj { get; } = obj;
    }
}
