using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormFieldValues
    {
		List<IFormFieldValue> Field { get; set; }
    }
}
