using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampRequestConfirmedData
    {
		IAnnotationPoint Position { get; set; }
		int Section { get; set; }
		int Page { get; set; }
		int Layer { get; set; }
		int DecisionId { get; set; }
		string Comment { get; set; }
    }
}
