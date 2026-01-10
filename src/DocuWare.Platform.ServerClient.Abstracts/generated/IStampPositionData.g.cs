using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampPositionData : IConfirmedData
    {
		string SectionId { get; set; }
		int Page { get; set; }
    }
}
