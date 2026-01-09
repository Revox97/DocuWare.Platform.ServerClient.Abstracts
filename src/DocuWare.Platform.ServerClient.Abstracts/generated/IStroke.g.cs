using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStroke
    {
		List<IAnnotationPoint> Point { get; set; }
		bool _do_not_use { get; set; }
    }
}
