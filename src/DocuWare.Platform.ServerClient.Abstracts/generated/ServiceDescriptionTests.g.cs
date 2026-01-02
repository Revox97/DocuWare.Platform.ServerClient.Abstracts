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

        public string HtmlTestClientRelationLink => Obj.HtmlTestClientRelationLink;

        public string ReflectStampPlacementRelationLink => Obj.ReflectStampPlacementRelationLink;

        public string ReflectDialogQueryRelationLink => Obj.ReflectDialogQueryRelationLink;

        public string QueryStringRelationLink => Obj.QueryStringRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public async Stream GetStreamFromHtmlTestClientRelation() => Obj.GetStreamFromHtmlTestClientRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromHtmlTestClientRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromHtmlTestClientRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromHtmlTestClientRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public StampPlacement PostToReflectStampPlacementRelationForStampPlacement(IStampPlacement dataToSend) => new StampPlacement(Obj.PostToReflectStampPlacementRelationForStampPlacement(dataToSend));

        public async Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.StampPlacement> result = await Obj.PostToReflectStampPlacementRelationForStampPlacementAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new StampPlacement(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<StampPlacement>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IStampPlacement>> PostToReflectStampPlacementRelationForStampPlacementAsync(CancellationToken cancellationToken, IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.StampPlacement> result = await Obj.PostToReflectStampPlacementRelationForStampPlacementAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new StampPlacement(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<StampPlacement>(temp).ConfigureAwait(false);
        }

        public DialogExpression PostToReflectDialogQueryRelationForDialogExpression(IDialogExpression dataToSend) => new DialogExpression(Obj.PostToReflectDialogQueryRelationForDialogExpression(dataToSend));

        public async Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(IDialogExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogExpression> result = await Obj.PostToReflectDialogQueryRelationForDialogExpressionAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogExpression(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogExpression>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogExpression>> PostToReflectDialogQueryRelationForDialogExpressionAsync(CancellationToken cancellationToken, IDialogExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogExpression> result = await Obj.PostToReflectDialogQueryRelationForDialogExpressionAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogExpression(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogExpression>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromQueryStringRelation() => Obj.GetStreamFromQueryStringRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromQueryStringRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromQueryStringRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromQueryStringRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
