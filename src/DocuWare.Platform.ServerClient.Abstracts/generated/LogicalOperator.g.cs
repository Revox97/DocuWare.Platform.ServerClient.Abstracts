using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LogicalOperator(SDK.LogicalOperator obj) : ILogicalOperator
    {
        internal SDK.LogicalOperator Obj { get; } = obj;

		public DialogExpressionOperation DefaultOperator
		{
			get => new ialogExpressionOperation(Obj.DefaultOperator);
			set => Obj.DefaultOperator = ((ialogExpressionOperation)value).Obj;
		}

		public bool Show
		{
			get => Obj.Show;
			set => Obj.Show = value;
		}
    }
}
