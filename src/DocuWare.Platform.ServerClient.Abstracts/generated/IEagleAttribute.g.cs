using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEagleAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
