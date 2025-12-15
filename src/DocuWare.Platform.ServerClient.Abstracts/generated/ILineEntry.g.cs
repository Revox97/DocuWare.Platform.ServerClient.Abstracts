using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILineEntry
    {
		IAnnotationPoint From { get; set; }
		IAnnotationPoint To { get; set; }
		bool Arrow { get; set; }
		ICreatedInfo Created { get; set; }
		string Type { get; set; }
		string Color { get; set; }
		int Rotation { get; set; }
		bool Transparent { get; set; }
		int StrokeWidth { get; set; }
		string Id { get; set; }
    }
}
