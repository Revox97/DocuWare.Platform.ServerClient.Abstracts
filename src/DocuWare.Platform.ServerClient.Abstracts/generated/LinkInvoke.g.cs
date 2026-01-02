using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkInvoke(DocuWare.Platform.ServerClient.LinkInvoke obj) : ILinkInvoke
    {
        internal DocuWare.Platform.ServerClient.LinkInvoke Obj { get; } = obj;

        public HttpMethod Verb
        {
            get => (HttpMethod)Obj.Verb;
            set => Obj.Verb = (DocuWare.Platform.ServerClient.HttpMethod)value;
        }
    }
}
