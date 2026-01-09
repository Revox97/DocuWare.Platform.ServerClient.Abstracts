using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IConfirmedData
    {
		List<IConfirmedField> ConfirmedFields { get; set; }
    }
}
