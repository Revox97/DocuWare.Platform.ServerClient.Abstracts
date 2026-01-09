using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColumnSelectListExpressionCondition : IDialogExpressionCondition
    {
		string Type { get; set; }
    }
}
