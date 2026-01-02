using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IClientTimeoutException
    {
		string Message { get; }
		System.Collections.IDictionary Data { get; }
    }
}
