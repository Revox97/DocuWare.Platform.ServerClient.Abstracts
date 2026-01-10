using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchRestoreFailedResultItem
    {
		string Id { get; set; }
		string ErrorMessage { get; set; }
    }
}
