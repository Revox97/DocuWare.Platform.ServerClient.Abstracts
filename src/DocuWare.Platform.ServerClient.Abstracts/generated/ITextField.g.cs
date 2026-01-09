using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextField: IWebFormField
    {
		int? MinLength { get; set; }
		int? MaxLength { get; set; }
    }
}
