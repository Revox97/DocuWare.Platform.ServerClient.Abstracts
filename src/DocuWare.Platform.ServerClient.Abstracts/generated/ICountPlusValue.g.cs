using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountPlusValue
    {
		bool HasMore { get; set; }
		bool ExceedLimit { get; set; }
		int Value { get; set; }
    }
}
