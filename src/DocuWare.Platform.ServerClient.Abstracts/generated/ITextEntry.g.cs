using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextEntry : IEntryBase
    {
		IFont Font { get; set; }
		string Value { get; set; }
		IAnnotationRectangle Location { get; set; }
    }
}
