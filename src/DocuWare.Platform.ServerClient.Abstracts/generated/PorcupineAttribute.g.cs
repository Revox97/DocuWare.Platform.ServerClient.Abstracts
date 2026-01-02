using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PorcupineAttribute(SDK.PorcupineAttribute obj) : IPorcupineAttribute
    {
        internal SDK.PorcupineAttribute Obj { get; } = obj;
    }
}
