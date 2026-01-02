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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromAsBitmapRelation() => Obj.GetStreamFromAsBitmapRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync() => await Obj.GetStreamFromAsBitmapRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAsBitmapRelationAsync(cancellationToken);

		public Stream PostToAsBitmapRelationForStream(IFormFieldValues dataToSend) => Obj.PostToAsBitmapRelationForStream(((FormFieldValues)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(IFormFieldValues dataToSend) => await Obj.PostToAsBitmapRelationForStreamAsync(((FormFieldValues)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend) => await Obj.PostToAsBitmapRelationForStreamAsync(cancellationToken, ((FormFieldValues)dataToSend).Obj);

		public Stream GetStreamFromAsSvgRelation() => Obj.GetStreamFromAsSvgRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync() => await Obj.GetStreamFromAsSvgRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAsSvgRelationAsync(cancellationToken);

		public Stream PostToAsSvgRelationForStream(IFormFieldValues dataToSend) => Obj.PostToAsSvgRelationForStream(((FormFieldValues)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(IFormFieldValues dataToSend) => await Obj.PostToAsSvgRelationForStreamAsync(((FormFieldValues)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend) => await Obj.PostToAsSvgRelationForStreamAsync(cancellationToken, ((FormFieldValues)dataToSend).Obj);
    }
}
