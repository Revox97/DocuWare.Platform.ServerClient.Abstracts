using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkInvoke
    {
		IContentTypeList Accepts { get; set; }
		IContentTypeList Produces { get; set; }
		DocuWare.Platform.ServerClient.HttpMethod Verb { get; set; }
    }
}
