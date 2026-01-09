using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinQuery
    {
		List<ISortedField> SortOrder { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool CalculateTotalCount { get; set; }
    }
}
