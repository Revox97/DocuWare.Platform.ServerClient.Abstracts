using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPolyLineStampEntry : IStampBase
    {
		List<IStroke> Stroke { get; set; }
    }
}
