using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStamp{3}
    {
		List<IStampFormField> FormField { get; set; }
		List<IStampField> Fields { get; set; }
		object Item { get; set; }
		Link[] Links { get; set; }
		bool PasswordProtected { get; set; }
		StampSignatureType Signature { get; set; }
		string Color { get; set; }
		string Name { get; set; }
		string DisplayName { get; set; }
		bool Overwrite { get; set; }
		string Id { get; set; }
		bool IsHidden { get; set; }
		int Autosave { get; set; }
		bool CloseAfterStampSet { get; set; }
		bool AutomaticallyOpenNextDocument { get; set; }
		bool KeepStampActive { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromAsBitmapRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAsBitmapRelationAsync(CancellationToken cancellationToken);
		Stream PostToAsBitmapRelationForStream(IFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(IFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToAsBitmapRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend);
		Stream GetStreamFromAsSvgRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAsSvgRelationAsync(CancellationToken cancellationToken);
		Stream PostToAsSvgRelationForStream(IFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(IFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToAsSvgRelationForStreamAsync(CancellationToken cancellationToken, IFormFieldValues dataToSend);
    }
}
