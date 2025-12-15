using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFunctionExpressionQuery
    {
		List<ISortedField> SortOrder { get; set; }
		List<string> ResultFields { get; set; }
		IFunctionExpression Expression { get; set; }
		int Start { get; set; }
		int Count { get; set; }
    }
}
