using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDropDownList: IWebFormField
    {
		List<string> Options { get; set; }
    }
}
