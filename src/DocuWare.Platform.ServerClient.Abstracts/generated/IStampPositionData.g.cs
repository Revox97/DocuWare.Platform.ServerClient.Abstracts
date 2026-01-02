using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampPositionData
    {
		List<IConfirmedField> ConfirmedFields { get; set; }
    }
}
