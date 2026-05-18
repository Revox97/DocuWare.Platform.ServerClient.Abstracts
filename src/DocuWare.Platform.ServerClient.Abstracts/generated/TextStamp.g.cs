using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextStamp(SDK.TextStamp obj) : ITextStamp
    {
        internal SDK.TextStamp Obj { get; } = obj;

        public IFont Font
        {
            get => new Font(Obj.Font);
            set => Obj.Font = ((Font)value).Obj;
        }

        public string Content
        {
            get => Obj.Content;
            set => Obj.Content = value;
        }
    }
}
