using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampPositionData
    {
		string SectionId { get; set; }
		int Page { get; set; }
		List<IConfirmedField> ConfirmedFields { get; set; }
    }
}
