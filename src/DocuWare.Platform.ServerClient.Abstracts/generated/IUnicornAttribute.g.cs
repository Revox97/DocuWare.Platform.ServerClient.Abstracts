using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUnicornAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
