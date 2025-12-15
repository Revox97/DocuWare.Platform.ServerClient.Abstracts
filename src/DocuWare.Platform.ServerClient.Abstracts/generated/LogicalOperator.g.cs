using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LogicalOperator(SDK.LogicalOperator obj) : ILogicalOperator
    {
        internal SDK.LogicalOperator Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.DialogExpressionOperation DefaultOperator
        {
            get => Obj.DefaultOperator;
            set => Obj.DefaultOperator = value;
        }

        public bool Show
        {
            get => Obj.Show;
            set => Obj.Show = value;
        }
    }
}
