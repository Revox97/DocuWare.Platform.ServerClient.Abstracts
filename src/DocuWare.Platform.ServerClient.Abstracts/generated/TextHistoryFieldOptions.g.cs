using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextHistoryFieldOptions(SDK.TextHistoryFieldOptions obj) : ITextHistoryFieldOptions
    {
        internal SDK.TextHistoryFieldOptions Obj { get; } = obj;

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }
    }
}
