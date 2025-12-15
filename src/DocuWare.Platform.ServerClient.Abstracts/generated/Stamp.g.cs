using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Stamp(SDK.Stamp obj) : IStamp
    {
        internal SDK.Stamp Obj { get; } = obj;

        public List<IStampFormField> FormField
        {
            get => Obj.FormField.Select(x => new StampFormField(x) as IStampFormField).ToList();
            set => Obj.FormField = value.Select(x => ((StampFormField)x).Obj).ToList();
        }

        public List<IStampField> Fields
        {
            get => Obj.Fields.Select(x => new StampField(x) as IStampField).ToList();
            set => Obj.Fields = value.Select(x => ((StampField)x).Obj).ToList();
        }

        public IFont HeadFont
        {
            get => new Font(Obj.HeadFont);
            set => Obj.HeadFont = ((Font)value).Obj;
        }

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public bool PasswordProtected
        {
            get => Obj.PasswordProtected;
            set => Obj.PasswordProtected = value;
        }

        public DocuWare.Platform.ServerClient.StampSignatureType Signature
        {
            get => Obj.Signature;
            set => Obj.Signature = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string DisplayName
        {
            get => Obj.DisplayName;
            set => Obj.DisplayName = value;
        }

        public bool Overwrite
        {
            get => Obj.Overwrite;
            set => Obj.Overwrite = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool IsHidden
        {
            get => Obj.IsHidden;
            set => Obj.IsHidden = value;
        }

        public int Autosave
        {
            get => Obj.Autosave;
            set => Obj.Autosave = value;
        }

        public bool CloseAfterStampSet
        {
            get => Obj.CloseAfterStampSet;
            set => Obj.CloseAfterStampSet = value;
        }

        public bool AutomaticallyOpenNextDocument
        {
            get => Obj.AutomaticallyOpenNextDocument;
            set => Obj.AutomaticallyOpenNextDocument = value;
        }

        public bool KeepStampActive
        {
            get => Obj.KeepStampActive;
            set => Obj.KeepStampActive = value;
        }

        public string AsBitmapRelationLink => Obj.AsBitmapRelationLink;

        public string AsSvgRelationLink => Obj.AsSvgRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public async Stream GetStreamFromAsBitmapRelation() => Obj.GetStreamFromAsBitmapRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAsBitmapRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAsBitmapRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToAsBitmapRelationForStream(IFormFieldValues dataToSend) => Obj.PostToAsBitmapRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(IFormFieldValues dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToAsBitmapRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToAsBitmapRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromAsSvgRelation() => Obj.GetStreamFromAsSvgRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAsSvgRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAsSvgRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToAsSvgRelationForStream(IFormFieldValues dataToSend) => Obj.PostToAsSvgRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(IFormFieldValues dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToAsSvgRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToAsSvgRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
