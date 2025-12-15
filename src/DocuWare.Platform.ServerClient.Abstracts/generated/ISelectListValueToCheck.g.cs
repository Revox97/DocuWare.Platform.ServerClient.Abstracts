using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValueToCheck
    {
		string Value { get; set; }
		string Type { get; set; }
    }
}
