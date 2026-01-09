using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskFieldValue: ITaskFieldValueBase
    {
		object Item { get; set; }
    }
}
