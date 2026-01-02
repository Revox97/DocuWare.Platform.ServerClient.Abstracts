using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LogicalOperator(DocuWare.Platform.ServerClient.LogicalOperator obj) : ILogicalOperator
    {
        internal DocuWare.Platform.ServerClient.LogicalOperator Obj { get; } = obj;

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
