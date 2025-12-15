using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHttpMethodList
    {
		List<HttpMethod> Method { get; set; }
		bool IsComplete { get; set; }
    }
}
