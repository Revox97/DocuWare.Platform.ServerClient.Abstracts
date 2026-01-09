using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampConfirmedData: IConfirmedData
    {
		List<IConfirmedField> ConfirmedFields { get; set; }
    }
}
