using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateDialogExpressionSource : IBatchUpdateSource
    {
		IDialogExpression Expression { get; set; }
    }
}
