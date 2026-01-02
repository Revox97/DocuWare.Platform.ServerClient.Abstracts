using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescriptionTests(SDK.ServiceDescriptionTests obj) : IServiceDescriptionTests
    {
        internal SDK.ServiceDescriptionTests Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromHtmlTestClientRelation() => Obj.GetStreamFromHtmlTestClientRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync() => await Obj.GetStreamFromHtmlTestClientRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromHtmlTestClientRelationAsync(cancellationToken);

        public IStampPlacement PostToReflectStampPlacementRelationForStampPlacement(IStampPlacement dataToSend) => new StampPlacement(Obj.PostToReflectStampPlacementRelationForStampPlacement(((StampPlacement)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.StampPlacement> result = await Obj.PostToReflectStampPlacementRelationForStampPlacementAsync(((StampPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new StampPlacement(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStampPlacement>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(CancellationToken cancellationToken, IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.StampPlacement> result = await Obj.PostToReflectStampPlacementRelationForStampPlacementAsync(cancellationToken, ((StampPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new StampPlacement(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStampPlacement>(temp).ConfigureAwait(false);
        }

        public IDialogExpression PostToReflectDialogQueryRelationForDialogExpression(IDialogExpression dataToSend) => new DialogExpression(Obj.PostToReflectDialogQueryRelationForDialogExpression(((DialogExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(IDialogExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogExpression> result = await Obj.PostToReflectDialogQueryRelationForDialogExpressionAsync(((DialogExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogExpression(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogExpression>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(CancellationToken cancellationToken, IDialogExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogExpression> result = await Obj.PostToReflectDialogQueryRelationForDialogExpressionAsync(cancellationToken, ((DialogExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogExpression(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogExpression>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromQueryStringRelation() => Obj.GetStreamFromQueryStringRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync() => await Obj.GetStreamFromQueryStringRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromQueryStringRelationAsync(cancellationToken);
    }
}
