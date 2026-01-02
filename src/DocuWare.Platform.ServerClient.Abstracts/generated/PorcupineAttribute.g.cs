using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PorcupineAttribute(DocuWare.Platform.ServerClient.PorcupineAttribute obj) : IPorcupineAttribute
    {
        internal DocuWare.Platform.ServerClient.PorcupineAttribute Obj { get; } = obj;
    }
}
