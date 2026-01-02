using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TucanAttribute(DocuWare.Platform.ServerClient.TucanAttribute obj) : ITucanAttribute
    {
        internal DocuWare.Platform.ServerClient.TucanAttribute Obj { get; } = obj;
    }
}
