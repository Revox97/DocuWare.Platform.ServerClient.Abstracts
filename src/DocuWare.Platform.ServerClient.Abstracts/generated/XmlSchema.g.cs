using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class XmlSchema(SDK.XmlSchema obj) : IXmlSchema
    {
        internal SDK.XmlSchema Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string TargetNamespace
		{
			get => Obj.TargetNamespace;
			set => Obj.TargetNamespace = value;
		}

		public string SchemaRelationLink => Obj.SchemaRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
		public async Stream GetStreamFromSchemaRelation() => Obj.GetStreamFromSchemaRelation();
        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromSchemaRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromSchemaRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

    }
}
