using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPolyLineEntry : IEntryBase
    {
		IStroke Stroke { get; set; }
    }
}
