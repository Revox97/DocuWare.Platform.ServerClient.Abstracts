using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAuthenticationServiceCommunicationException
    {
		string Message { get; }
		IDictionary Data { get; }
    }
}
