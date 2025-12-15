using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStarfishAttribute
    {
		string MinumumVersion { get; set; }
		object TypeId { get; }
    }
}
