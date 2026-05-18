using DocuWare.Platform.ServerClient;

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
