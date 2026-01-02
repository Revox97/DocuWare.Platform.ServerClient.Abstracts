using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IClientTimeoutException
    {
		string Message { get; }
		IDictionary Data { get; }
    }
}
