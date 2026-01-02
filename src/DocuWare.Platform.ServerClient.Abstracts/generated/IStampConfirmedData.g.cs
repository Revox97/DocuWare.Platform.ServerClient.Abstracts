using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampConfirmedData
    {
		List<IConfirmedField> ConfirmedFields { get; set; }
    }
}
