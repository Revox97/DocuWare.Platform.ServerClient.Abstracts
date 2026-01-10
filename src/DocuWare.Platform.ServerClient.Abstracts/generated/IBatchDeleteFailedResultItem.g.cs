using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchDeleteFailedResultItem
    {
		string Id { get; set; }
		string ErrorMessage { get; set; }
    }
}
