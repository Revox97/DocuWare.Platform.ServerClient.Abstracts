using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHawkAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
