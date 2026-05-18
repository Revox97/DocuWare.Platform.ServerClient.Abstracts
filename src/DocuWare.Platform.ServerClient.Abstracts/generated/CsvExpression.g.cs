using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CsvExpression(SDK.CsvExpression obj) : ICsvExpression
    {
        internal SDK.CsvExpression Obj { get; } = obj;

        public IDialogExpression DialogExpression
        {
            get => new DialogExpression(Obj.DialogExpression);
            set => Obj.DialogExpression = ((DialogExpression)value).Obj;
        }

        public string Delimiter
        {
            get => Obj.Delimiter;
            set => Obj.Delimiter = value;
        }

        public bool IsUtc
        {
            get => Obj.IsUtc;
            set => Obj.IsUtc = value;
        }
    }
}
