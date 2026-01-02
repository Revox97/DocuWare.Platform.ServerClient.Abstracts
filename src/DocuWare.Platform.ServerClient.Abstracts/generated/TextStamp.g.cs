using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextStamp(SDK.TextStamp obj) : ITextStamp
    {
        internal SDK.TextStamp Obj { get; } = obj;
    }
}
