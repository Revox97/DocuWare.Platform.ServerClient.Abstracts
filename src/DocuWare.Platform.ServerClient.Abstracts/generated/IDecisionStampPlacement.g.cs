using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionStampPlacement
    {
		string WorkflowId { get; set; }
		string InstanceId { get; set; }
		string TaskId { get; set; }
		int DecisionId { get; set; }
		bool IsController { get; set; }
		IPolyLineEntry Strokes { get; set; }
		IDWPoint Location { get; set; }
		List<IFormFieldValue> Field { get; set; }
		string StampId { get; set; }
		int Rotation { get; set; }
		int Layer { get; set; }
		string Password { get; set; }
    }
}
