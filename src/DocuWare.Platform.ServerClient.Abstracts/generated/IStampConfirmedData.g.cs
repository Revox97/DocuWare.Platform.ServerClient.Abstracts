using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampConfirmedData : IConfirmedData
    {
		IAnnotationPoint Position { get; set; }
		int Section { get; set; }
		int Page { get; set; }
		int Layer { get; set; }
    }
}
