using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IConfirmedField
    {
		IWFFormFieldValue Value { get; set; }
		int Id { get; set; }
    }
}
