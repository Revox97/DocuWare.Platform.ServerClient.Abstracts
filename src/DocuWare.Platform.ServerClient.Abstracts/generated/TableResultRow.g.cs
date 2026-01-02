using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableResultRow(SDK.TableResultRow obj) : ITableResultRow
    {
        internal SDK.TableResultRow Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<ISuggestionField> Suggestions
        {
            get => Obj.Suggestions.Select(x => new SuggestionField(x) as ISuggestionField).ToList();
            set => Obj.Suggestions = value.Select(x => ((SuggestionField)x).Obj).ToList();
        }

        public List<ISuggestionTableField> TableFieldSuggestions
        {
            get => Obj.TableFieldSuggestions.Select(x => new SuggestionTableField(x) as ISuggestionTableField).ToList();
            set => Obj.TableFieldSuggestions = value.Select(x => ((SuggestionTableField)x).Obj).ToList();
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool AnnotationsPreview
        {
            get => Obj.AnnotationsPreview;
            set => Obj.AnnotationsPreview = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string FieldsRelationLink => Obj.FieldsRelationLink;

        public string SuggestionsRelationLink => Obj.SuggestionsRelationLink;

        public string TableFieldsSuggestionsRelationLink => Obj.TableFieldsSuggestionsRelationLink;

        public string ClippedDocumentsRelationLink => Obj.ClippedDocumentsRelationLink;

        public string SectionsRelationLink => Obj.SectionsRelationLink;

        public string ThumbnailRelationLink => Obj.ThumbnailRelationLink;

        public string ThumbnailWithoutAnnotationRelationLink => Obj.ThumbnailWithoutAnnotationRelationLink;

        public string AnnotationAsSvgRelationLink => Obj.AnnotationAsSvgRelationLink;

        public string LowQualityImageRelationLink => Obj.LowQualityImageRelationLink;

        public string LockRelationLink => Obj.LockRelationLink;

        public string RightsRelationLink => Obj.RightsRelationLink;

        public string IntellixRelationLink => Obj.IntellixRelationLink;

        public string TextshotPreviewRelationLink => Obj.TextshotPreviewRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Document GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public Document PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToSelfRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation() => new DocumentIndexFields(Obj.GetDocumentIndexFieldsFromFieldsRelation());

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public SuggestionFields GetSuggestionFieldsFromSuggestionsRelation() => new SuggestionFields(Obj.GetSuggestionFieldsFromSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionFields>(temp).ConfigureAwait(false);
        }

        public SuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation() => new SuggestionTableFields(Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public Document PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend) => new Document(Obj.PutToClippedDocumentsRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public Sections GetSectionsFromSectionsRelation() => new Sections(Obj.GetSectionsFromSectionsRelation());

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Sections>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Sections>(temp).ConfigureAwait(false);
        }

        public Section PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToSectionsRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromThumbnailWithoutAnnotationRelation() => Obj.GetStreamFromThumbnailWithoutAnnotationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromLowQualityImageRelation() => Obj.GetStreamFromLowQualityImageRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string PostToLockRelationForString(ILockInfo dataToSend) => Obj.PostToLockRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLockRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLockRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async string DeleteLockRelation() => Obj.DeleteLockRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteLockRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteLockRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public Rights PostToRightsRelationForRights(IRights dataToSend) => new Rights(Obj.PostToRightsRelationForRights(dataToSend));

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Rights>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Rights>(temp).ConfigureAwait(false);
        }

		public async string GetStringFromTextshotPreviewRelation() => Obj.GetStringFromTextshotPreviewRelation();

        public async Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromTextshotPreviewRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromTextshotPreviewRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }
    }
}
