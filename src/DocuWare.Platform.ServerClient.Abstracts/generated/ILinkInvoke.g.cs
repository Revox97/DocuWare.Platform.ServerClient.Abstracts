using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkInvoke
    {
		HttpMethod Verb { get; set; }
    }
}
