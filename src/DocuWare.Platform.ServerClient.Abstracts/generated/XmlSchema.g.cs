using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromSchemaRelation() => Obj.GetStreamFromSchemaRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync() => await Obj.GetStreamFromSchemaRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromSchemaRelationAsync(cancellationToken);
    }
}
