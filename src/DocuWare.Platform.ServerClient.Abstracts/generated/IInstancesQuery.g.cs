using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IInstancesQuery
    {
		List<string> Instances { get; set; }
		List<IColumnSortOrder> SortOrder { get; set; }
		List<IInstanceExpressionCondition> InstanceExpressionCondition { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool LoadColumnValues { get; set; }
		bool RemoveLinks { get; set; }
		InstanceExpressionOperation Operation { get; set; }
    }
}
