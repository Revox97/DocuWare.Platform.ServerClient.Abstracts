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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocument GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);

        public IDocument PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToSelfRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation() => new DocumentIndexFields(Obj.GetDocumentIndexFieldsFromFieldsRelation());

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(((DocumentIndexFields)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(((DocumentIndexFields)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, ((DocumentIndexFields)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(((UpdateIndexFieldsInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(((UpdateIndexFieldsInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, ((UpdateIndexFieldsInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionFields GetSuggestionFieldsFromSuggestionsRelation() => new SuggestionFields(Obj.GetSuggestionFieldsFromSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation() => new SuggestionTableFields(Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public IDocument PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend) => new Document(Obj.PutToClippedDocumentsRelationForDocument(((IntegerList)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(((IntegerList)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(cancellationToken, ((IntegerList)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public ISections GetSectionsFromSectionsRelation() => new Sections(Obj.GetSectionsFromSectionsRelation());

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public ISection PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToSectionsRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync() => await Obj.GetStreamFromThumbnailRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken);

		public Stream GetStreamFromThumbnailWithoutAnnotationRelation() => Obj.GetStreamFromThumbnailWithoutAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync() => await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync(cancellationToken);

		public Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync() => await Obj.GetStreamFromAnnotationAsSvgRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken);

		public Stream GetStreamFromLowQualityImageRelation() => Obj.GetStreamFromLowQualityImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync() => await Obj.GetStreamFromLowQualityImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken);

		public string PostToLockRelationForString(ILockInfo dataToSend) => Obj.PostToLockRelationForString(((LockInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend) => await Obj.PostToLockRelationForStringAsync(((LockInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend) => await Obj.PostToLockRelationForStringAsync(cancellationToken, ((LockInfo)dataToSend).Obj);

		public string DeleteLockRelation() => Obj.DeleteLockRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync() => await Obj.DeleteLockRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteLockRelationAsync(cancellationToken);

        public IRights PostToRightsRelationForRights(IRights dataToSend) => new Rights(Obj.PostToRightsRelationForRights(((Rights)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(((Rights)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(cancellationToken, ((Rights)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

		public string GetStringFromTextshotPreviewRelation() => Obj.GetStringFromTextshotPreviewRelation();

		public async Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync() => await Obj.GetStringFromTextshotPreviewRelationAsync();

		public async Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync(CancellationToken cancellationToken) => await Obj.GetStringFromTextshotPreviewRelationAsync(cancellationToken);
    }
}
