using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAnnotation
    {
		List<ILayer> Layer { get; set; }
    }
}
