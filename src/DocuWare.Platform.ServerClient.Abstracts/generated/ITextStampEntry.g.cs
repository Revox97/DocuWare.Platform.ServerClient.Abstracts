using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextStampEntry : IStampBase
    {
		IFont Font { get; set; }
		string Value { get; set; }
    }
}
