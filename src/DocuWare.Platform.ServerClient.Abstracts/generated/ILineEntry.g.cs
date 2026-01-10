using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILineEntry : IEntryBase
    {
		IAnnotationPoint From { get; set; }
		IAnnotationPoint To { get; set; }
		bool Arrow { get; set; }
    }
}
