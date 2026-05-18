using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkInvoke(SDK.LinkInvoke obj) : ILinkInvoke
    {
        internal SDK.LinkInvoke Obj { get; } = obj;

        public IContentTypeList Accepts
        {
            get => new ContentTypeList(Obj.Accepts);
            set => Obj.Accepts = ((ContentTypeList)value).Obj;
        }

        public IContentTypeList Produces
        {
            get => new ContentTypeList(Obj.Produces);
            set => Obj.Produces = ((ContentTypeList)value).Obj;
        }

        public HttpMethod Verb
        {
            get => (HttpMethod)Obj.Verb;
            set => Obj.Verb = (DocuWare.Platform.ServerClient.HttpMethod)value;
        }
    }
}
