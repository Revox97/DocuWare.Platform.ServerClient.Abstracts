using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISignatureField : IWebFormField
    {
		string Color { get; set; }
    }
}
