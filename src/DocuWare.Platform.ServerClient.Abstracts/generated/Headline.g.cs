using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Headline(DocuWare.Platform.ServerClient.Headline obj) : IHeadline
    {
        internal DocuWare.Platform.ServerClient.Headline Obj { get; } = obj;
    }
}
