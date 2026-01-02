using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ToggleBehaviorAction(SDK.ToggleBehaviorAction obj) : IToggleBehaviorAction
    {
        internal SDK.ToggleBehaviorAction Obj { get; } = obj;
    }
}
