using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchDeleteResult
    {
		List<Link> Links { get; set; }
		List<IBatchDeleteFailedResultItem> FailedItems { get; set; }
		int SuccessCount { get; set; }
    }
}
