using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextStamp
    {
		IFont Font { get; set; }
		string Content { get; set; }
    }
}
