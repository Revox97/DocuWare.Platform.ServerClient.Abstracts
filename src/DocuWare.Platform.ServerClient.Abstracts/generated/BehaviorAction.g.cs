using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BehaviorAction(SDK.BehaviorAction obj) : IBehaviorAction
    {
        internal SDK.BehaviorAction Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
