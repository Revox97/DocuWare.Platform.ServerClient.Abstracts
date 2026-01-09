using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchRestoreResult
    {
		List<Link> Links { get; set; }
		List<IBatchRestoreFailedResultItem> FailedItems { get; set; }
		int SuccessCount { get; set; }
    }
}
