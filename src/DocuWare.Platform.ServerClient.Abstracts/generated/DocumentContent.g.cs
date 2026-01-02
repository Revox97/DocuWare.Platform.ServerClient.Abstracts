using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentContent(DocuWare.Platform.ServerClient.Content.DocumentContent obj) : IDocumentContent
    {
        internal DocuWare.Platform.ServerClient.Content.DocumentContent Obj { get; } = obj;

        public List<IKeyValuePair> metadata
        {
            get => Obj.metadata.Select(x => new KeyValuePair(x) as IKeyValuePair).ToList();
            set => Obj.metadata = value.Select(x => ((KeyValuePair)x).Obj).ToList();
        }

        public List<XElementWrapper> Embedded
        {
            get => Obj.Embedded;
            set => Obj.Embedded = value;
        }

        public List<IPageContent> Pages
        {
            get => Obj.Pages.Select(x => new PageContent(x) as IPageContent).ToList();
            set => Obj.Pages = value.Select(x => ((PageContent)x).Obj).ToList();
        }
    }
}
