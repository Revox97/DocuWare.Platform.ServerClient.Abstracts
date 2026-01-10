using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormsInput
    {
		IFormInfo FormInfo { get; set; }
		string HTML { get; set; }
    }
}
