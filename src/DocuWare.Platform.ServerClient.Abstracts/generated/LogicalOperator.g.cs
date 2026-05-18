using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LogicalOperator(SDK.LogicalOperator obj) : ILogicalOperator
    {
        internal SDK.LogicalOperator Obj { get; } = obj;

        public DialogExpressionOperation DefaultOperator
        {
            get => (DialogExpressionOperation)Obj.DefaultOperator;
            set => Obj.DefaultOperator = (DocuWare.Platform.ServerClient.DialogExpressionOperation)value;
        }

        public bool Show
        {
            get => Obj.Show;
            set => Obj.Show = value;
        }
    }
}
