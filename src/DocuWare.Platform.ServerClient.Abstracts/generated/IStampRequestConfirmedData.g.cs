using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampRequestConfirmedData
    {
		int DecisionId { get; set; }
		string Comment { get; set; }
    }
}
