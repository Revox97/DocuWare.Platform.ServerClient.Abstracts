using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISpacerField : IWebFormField
    {
		bool DisplayLine { get; set; }
    }
}
