using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportQuery(DocuWare.Platform.ServerClient.ExportQuery obj) : IExportQuery
    {
        internal DocuWare.Platform.ServerClient.ExportQuery Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
