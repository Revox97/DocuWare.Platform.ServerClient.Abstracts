using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BehaviorCondition(DocuWare.Platform.ServerClient.BehaviorCondition obj) : IBehaviorCondition
    {
        internal DocuWare.Platform.ServerClient.BehaviorCondition Obj { get; } = obj;
    }
}
