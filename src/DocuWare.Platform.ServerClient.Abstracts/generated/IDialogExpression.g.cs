using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogExpression : IResultListQuery
    {
		List<IDialogExpressionCondition> Condition { get; set; }
		List<string> AdditionalCabinets { get; set; }
		string CompleteCondition { get; set; }
		DialogExpressionOperation Operation { get; set; }
		bool CompleteConditionInInvariantCulture { get; set; }
    }
}
