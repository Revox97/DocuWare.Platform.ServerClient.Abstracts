using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITriggerVariable
    {
		IWFFormFieldValue Value { get; set; }
		string Id { get; set; }
    }
}
