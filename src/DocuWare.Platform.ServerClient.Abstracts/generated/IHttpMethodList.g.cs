using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHttpMethodList{3}
    {
		List<HttpMethod> Method { get; set; }
		bool IsComplete { get; set; }
    }
}
