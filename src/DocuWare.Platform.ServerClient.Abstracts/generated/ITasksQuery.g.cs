using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITasksQuery{3}
    {
		List<string> Instances { get; set; }
		List<IColumnSortOrder> SortOrder { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool RemoveLinks { get; set; }
    }
}
