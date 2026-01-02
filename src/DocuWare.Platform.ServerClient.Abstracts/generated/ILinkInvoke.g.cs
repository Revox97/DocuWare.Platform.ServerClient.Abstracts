using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkInvoke
    {
		DocuWare.Platform.ServerClient.HttpMethod Verb { get; set; }
    }
}
