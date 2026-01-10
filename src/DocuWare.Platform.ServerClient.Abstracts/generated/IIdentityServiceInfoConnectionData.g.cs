using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIdentityServiceInfoConnectionData
    {
		HttpMessageHandler HttpClientHandler { get; set; }
		CancellationToken CancellationToken { get; set; }
    }
}
