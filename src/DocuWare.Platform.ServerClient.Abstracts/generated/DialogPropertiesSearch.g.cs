using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
