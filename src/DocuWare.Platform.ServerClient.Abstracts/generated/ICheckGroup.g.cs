using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckGroup: IWebFormField
    {
		List<IWebFormOption> Options { get; set; }
		List<List<IWebFormOption>> OptionsRows { get; set; }
		List<string> PredefinedValues { get; set; }
    }
}
