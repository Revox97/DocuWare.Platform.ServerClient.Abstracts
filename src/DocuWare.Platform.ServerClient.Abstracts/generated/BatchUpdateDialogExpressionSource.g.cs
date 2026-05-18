using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDialogExpressionSource(SDK.BatchUpdateDialogExpressionSource obj) : IBatchUpdateDialogExpressionSource
    {
        internal SDK.BatchUpdateDialogExpressionSource Obj { get; } = obj;

        public IDialogExpression Expression
        {
            get => new DialogExpression(Obj.Expression);
            set => Obj.Expression = ((DialogExpression)value).Obj;
        }
    }
}
