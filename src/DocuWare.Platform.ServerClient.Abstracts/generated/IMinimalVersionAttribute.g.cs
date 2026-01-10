using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMinimalVersionAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
