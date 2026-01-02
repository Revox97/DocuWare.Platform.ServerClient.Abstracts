using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextStamp(DocuWare.Platform.ServerClient.TextStamp obj) : ITextStamp
    {
        internal DocuWare.Platform.ServerClient.TextStamp Obj { get; } = obj;
    }
}
