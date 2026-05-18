using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class DocumentContent(SDK.Content.DocumentContent obj) : IDocumentContent
    {
        internal SDK.Content.DocumentContent Obj { get; } = obj;

        public List<IKeyValuePair> metadata
        {
            get => Obj.metadata.Select(x => new DocuWare.Platform.ServerClient.Abstracts.Content.KeyValuePair(x) as IKeyValuePair).ToList();
            set => Obj.metadata = value.Select(x => ((DocuWare.Platform.ServerClient.Abstracts.Content.KeyValuePair)x).Obj).ToList();
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
