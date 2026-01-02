using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FixedText(SDK.FixedText obj) : IFixedText
    {
        internal SDK.FixedText Obj { get; } = obj;
    }
}
