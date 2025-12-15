using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImpalaAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
