using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebFormControls
    {
		List<IWebFormControl> WebFormControl { get; set; }
    }
}
