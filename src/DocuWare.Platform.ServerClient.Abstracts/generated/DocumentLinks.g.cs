using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentLinks(DocuWare.Platform.ServerClient.DocumentLinks obj) : IDocumentLinks
    {
        internal DocuWare.Platform.ServerClient.DocumentLinks Obj { get; } = obj;

        public List<IDocumentLink> Items
        {
            get => Obj.Items.Select(x => new DocumentLink(x) as IDocumentLink).ToList();
            set => Obj.Items = value.Select(x => ((DocumentLink)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
