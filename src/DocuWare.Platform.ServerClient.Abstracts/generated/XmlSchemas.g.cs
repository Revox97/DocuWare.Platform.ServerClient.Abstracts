using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class XmlSchemas(SDK.XmlSchemas obj) : IXmlSchemas
    {
        internal SDK.XmlSchemas Obj { get; } = obj;

        public List<IXmlSchema> Schema
        {
            get => Obj.Schema.Select(x => new XmlSchema(x) as IXmlSchema).ToList();
            set => Obj.Schema = value.Select(x => ((XmlSchema)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
