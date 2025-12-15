using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILogicalOperator
    {
		DialogExpressionOperation DefaultOperator { get; set; }
		bool Show { get; set; }
    }
}
