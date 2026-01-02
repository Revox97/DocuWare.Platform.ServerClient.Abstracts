using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FixedText(DocuWare.Platform.ServerClient.FixedText obj) : IFixedText
    {
        internal DocuWare.Platform.ServerClient.FixedText Obj { get; } = obj;
    }
}
