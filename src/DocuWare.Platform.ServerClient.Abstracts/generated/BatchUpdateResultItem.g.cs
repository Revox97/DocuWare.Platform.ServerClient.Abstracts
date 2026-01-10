using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateResultItem(DocuWare.Platform.ServerClient.BatchUpdateResultItem obj) : IBatchUpdateResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateResultItem Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
