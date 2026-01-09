using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionFormFieldValue : IFormFieldValue
    {
		int Id { get; set; }
    }
}
