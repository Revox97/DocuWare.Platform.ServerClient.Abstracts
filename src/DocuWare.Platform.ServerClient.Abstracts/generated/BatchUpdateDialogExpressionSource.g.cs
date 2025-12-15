using SDK = DocuWare.Platform.ServerClient;

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
