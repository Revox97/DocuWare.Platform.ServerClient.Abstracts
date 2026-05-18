using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeMapping(SDK.ContentTypeMapping obj) : IContentTypeMapping
    {
        internal SDK.ContentTypeMapping Obj { get; } = obj;

		public string GetContentTypeFromFileExtension(string fileExt) => Obj.GetContentTypeFromFileExtension(fileExt);
    }
}
