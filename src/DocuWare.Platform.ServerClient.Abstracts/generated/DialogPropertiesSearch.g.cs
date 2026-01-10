using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesSearch(DocuWare.Platform.ServerClient.DialogPropertiesSearch obj) : IDialogPropertiesSearch
    {
        internal DocuWare.Platform.ServerClient.DialogPropertiesSearch Obj { get; } = obj;

        public ILogicalOperator LogicalOperator
        {
            get => new LogicalOperator(Obj.LogicalOperator);
            set => Obj.LogicalOperator = ((LogicalOperator)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
