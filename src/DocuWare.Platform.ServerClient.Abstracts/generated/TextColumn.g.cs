using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextColumn(SDK.TextColumn obj) : ITextColumn
    {
        internal SDK.TextColumn Obj { get; } = obj;

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }
    }
}
