using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ToggleBehaviorAction(DocuWare.Platform.ServerClient.ToggleBehaviorAction obj) : IToggleBehaviorAction
    {
        internal DocuWare.Platform.ServerClient.ToggleBehaviorAction Obj { get; } = obj;
    }
}
