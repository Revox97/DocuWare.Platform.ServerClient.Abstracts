using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILogicalOperator
    {
		DocuWare.Platform.ServerClient.DialogExpressionOperation DefaultOperator { get; set; }
		bool Show { get; set; }
    }
}
