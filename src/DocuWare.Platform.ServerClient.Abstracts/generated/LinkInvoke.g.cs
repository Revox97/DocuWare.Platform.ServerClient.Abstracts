using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkInvoke(DocuWare.Platform.ServerClient.LinkInvoke obj) : ILinkInvoke
    {
        internal DocuWare.Platform.ServerClient.LinkInvoke Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.HttpMethod Verb
        {
            get => Obj.Verb;
            set => Obj.Verb = value;
        }
    }
}
