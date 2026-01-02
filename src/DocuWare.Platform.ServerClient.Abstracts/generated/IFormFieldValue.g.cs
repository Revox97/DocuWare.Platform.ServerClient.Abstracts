using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormFieldValue
    {
		string Name { get; set; }
		string Value { get; set; }
    }
}
