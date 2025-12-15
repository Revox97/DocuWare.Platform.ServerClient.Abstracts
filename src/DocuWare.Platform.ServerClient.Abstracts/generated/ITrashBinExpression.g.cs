using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinExpression
    {
		List<ITrashBinCondition> Condition { get; set; }
		DocuWare.Platform.ServerClient.TrashBinExpressionOperation Operation { get; set; }
    }
}
