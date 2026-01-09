using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRadioGroup : IWebFormField
    {
		List<IWebFormOption> Options { get; set; }
		List<List<IWebFormOption>> OptionsRows { get; set; }
    }
}
