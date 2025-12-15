using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStrokeStamp
    {
		uint StrokeWidth { get; set; }
		string StrokeColor { get; set; }
    }
}
