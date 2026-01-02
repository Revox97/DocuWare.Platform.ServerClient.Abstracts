using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Headline(SDK.Headline obj) : IHeadline
    {
        internal SDK.Headline Obj { get; } = obj;
    }
}
