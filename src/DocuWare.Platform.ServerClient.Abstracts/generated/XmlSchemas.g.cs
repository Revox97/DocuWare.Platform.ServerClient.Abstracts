using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class XmlSchemas(DocuWare.Platform.ServerClient.XmlSchemas obj) : IXmlSchemas
    {
        internal DocuWare.Platform.ServerClient.XmlSchemas Obj { get; } = obj;

        public List<IXmlSchema> Schema
        {
            get => Obj.Schema.Select(x => new XmlSchema(x) as IXmlSchema).ToList();
            set => Obj.Schema = value.Select(x => ((XmlSchema)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
