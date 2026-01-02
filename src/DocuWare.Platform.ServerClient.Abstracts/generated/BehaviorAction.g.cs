using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BehaviorAction(DocuWare.Platform.ServerClient.BehaviorAction obj) : IBehaviorAction
    {
        internal DocuWare.Platform.ServerClient.BehaviorAction Obj { get; } = obj;
    }
}
