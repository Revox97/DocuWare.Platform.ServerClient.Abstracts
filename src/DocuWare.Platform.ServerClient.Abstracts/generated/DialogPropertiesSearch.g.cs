using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesSearch(SDK.DialogPropertiesSearch obj) : IDialogPropertiesSearch
    {
        internal SDK.DialogPropertiesSearch Obj { get; } = obj;

		public ILogicalOperator LogicalOperator
		{
			get => new LogicalOperator(Obj.LogicalOperator);
			set => Obj.LogicalOperator = ((LogicalOperator)value).Obj;
		}
    }
}
