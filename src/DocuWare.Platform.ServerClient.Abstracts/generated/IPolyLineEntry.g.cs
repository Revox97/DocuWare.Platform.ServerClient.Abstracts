using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPolyLineEntry
    {
		IStroke Stroke { get; set; }
		ICreatedInfo Created { get; set; }
		string Type { get; set; }
		string Color { get; set; }
		int Rotation { get; set; }
		bool Transparent { get; set; }
		int StrokeWidth { get; set; }
		string Id { get; set; }
    }
}
