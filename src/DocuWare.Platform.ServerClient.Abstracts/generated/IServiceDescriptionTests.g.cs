using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceDescriptionTests
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromHtmlTestClientRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync(CancellationToken cancellationToken);
		IStampPlacement PostToReflectStampPlacementRelationForStampPlacement(IStampPlacement dataToSend);
		Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(IStampPlacement dataToSend);
		Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(CancellationToken cancellationToken, IStampPlacement dataToSend);
		IDialogExpression PostToReflectDialogQueryRelationForDialogExpression(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(CancellationToken cancellationToken, IDialogExpression dataToSend);
		Stream GetStreamFromQueryStringRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync(CancellationToken cancellationToken);
    }
}
