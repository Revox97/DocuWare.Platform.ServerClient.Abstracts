using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBehavior
    {
		List<IBehaviorCondition> Conditions { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string BehaviorID { get; set; }
		List<IBehaviorAction> PassActions { get; set; }
		List<IBehaviorAction> FailActions { get; set; }
    }
}
