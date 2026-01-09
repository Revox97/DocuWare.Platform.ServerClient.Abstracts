using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICFSSpecificValue
    {
		string ValueName { get; set; }
		string Value { get; set; }
    }
}
