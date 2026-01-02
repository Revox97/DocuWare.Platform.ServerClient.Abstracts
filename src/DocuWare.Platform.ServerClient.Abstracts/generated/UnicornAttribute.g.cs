using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UnicornAttribute(DocuWare.Platform.ServerClient.UnicornAttribute obj) : IUnicornAttribute
    {
        internal DocuWare.Platform.ServerClient.UnicornAttribute Obj { get; } = obj;
    }
}
