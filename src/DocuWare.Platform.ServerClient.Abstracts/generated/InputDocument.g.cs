using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputDocument(SDK.InputDocument obj) : IInputDocument
    {
        internal SDK.InputDocument Obj { get; } = obj;

        public string MediaType => Obj.MediaType;

        public List<IDocumentIndexField> Fields
        {
            get => Obj.Fields.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Fields = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }

        public IInputFlags Flags
        {
            get => new InputFlags(Obj.Flags);
            set => Obj.Flags = ((InputFlags)value).Obj;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IInputSection> Sections
        {
            get => Obj.Sections.Select(x => new InputSection(x) as IInputSection).ToList();
            set => Obj.Sections = value.Select(x => ((InputSection)x).Obj).ToList();
        }

        public IUploadedFileChunk FileChunk
        {
            get => new UploadedFileChunk(Obj.FileChunk);
            set => Obj.FileChunk = ((UploadedFileChunk)value).Obj;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocument GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }
    }
}
