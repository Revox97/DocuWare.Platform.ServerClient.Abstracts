using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentLinks(SDK.DocumentLinks obj) : IDocumentLinks
    {
        internal SDK.DocumentLinks Obj { get; } = obj;

        public List<IDocumentLink> Items
        {
            get => Obj.Items.Select(x => new DocumentLink(x) as IDocumentLink).ToList();
            set => Obj.Items = value.Select(x => ((DocumentLink)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
