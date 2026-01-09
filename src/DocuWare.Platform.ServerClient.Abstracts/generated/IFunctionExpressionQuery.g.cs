using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFunctionExpressionQuery{3}
    {
		List<ISortedField> SortOrder { get; set; }
		List<string> ResultFields { get; set; }
		int Start { get; set; }
		int Count { get; set; }
    }
}
