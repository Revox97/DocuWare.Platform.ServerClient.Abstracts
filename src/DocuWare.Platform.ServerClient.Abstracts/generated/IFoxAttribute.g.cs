using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFoxAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
