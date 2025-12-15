using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateResultItem(SDK.BatchUpdateResultItem obj) : IBatchUpdateResultItem
    {
        internal SDK.BatchUpdateResultItem Obj { get; } = obj;

        public IDocument Document
        {
            get => new Document(Obj.Document);
            set => Obj.Document = ((Document)value).Obj;
        }

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
