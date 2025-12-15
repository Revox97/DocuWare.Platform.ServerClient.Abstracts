using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDolphinAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
