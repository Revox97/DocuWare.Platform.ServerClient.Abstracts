using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDialogExpressionSource(DocuWare.Platform.ServerClient.BatchUpdateDialogExpressionSource obj) : IBatchUpdateDialogExpressionSource
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateDialogExpressionSource Obj { get; } = obj;

        public IDialogExpression Expression
        {
            get => new DialogExpression(Obj.Expression);
            set => Obj.Expression = ((DialogExpression)value).Obj;
        }
    }
}
