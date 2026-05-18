using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITasksQuery
    {
		List<string> Instances { get; set; }
		List<IColumnSortOrder> SortOrder { get; set; }
		List<ITaskExpressionCondition> TaskExpressionCondition { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool RemoveLinks { get; set; }
		TaskExpressionOperation Operation { get; set; }
    }
}
