using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Behaviors(SDK.Behaviors obj) : IBehaviors
    {
        internal SDK.Behaviors Obj { get; } = obj;

		public List<IBehavior> Behavior
		{
			get => Obj.Behavior.Select(x => new Behavior(x) as IBehavior).ToList();
			set => Obj.Behavior = value.Select(x => ((Behavior)x).Obj).ToList();
		}
    }
}
