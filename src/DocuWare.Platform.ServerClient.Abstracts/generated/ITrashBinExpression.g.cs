using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinExpression
    {
		List<ITrashBinCondition> Condition { get; set; }
		TrashBinExpressionOperation Operation { get; set; }
    }
}
