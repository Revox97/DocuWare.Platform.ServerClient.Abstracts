using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IXmlSchemas
    {
		List<IXmlSchema> Schema { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
