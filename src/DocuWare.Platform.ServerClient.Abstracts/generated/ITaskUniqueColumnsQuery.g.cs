using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskUniqueColumnsQuery
    {
		List<IColumnSortOrder> SortOrder { get; set; }
		List<ITaskExpressionCondition> TaskExpressionCondition { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		TaskExpressionOperation Operation { get; set; }
    }
}
