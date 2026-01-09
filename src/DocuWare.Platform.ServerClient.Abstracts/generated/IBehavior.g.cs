using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBehavior{3}
    {
		List<IBehaviorCondition> Conditions { get; set; }
		List<IBehaviorAction> PassActions { get; set; }
		List<IBehaviorAction> FailActions { get; set; }
    }
}
