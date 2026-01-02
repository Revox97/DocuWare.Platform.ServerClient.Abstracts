using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAuthenticationServiceCommunicationException
    {
		string Message { get; }
		System.Collections.IDictionary Data { get; }
    }
}
