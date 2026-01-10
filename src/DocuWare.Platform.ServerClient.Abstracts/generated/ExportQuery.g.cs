using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportQuery(DocuWare.Platform.ServerClient.ExportQuery obj) : IExportQuery
    {
        internal DocuWare.Platform.ServerClient.ExportQuery Obj { get; } = obj;

        public IExportSettings Settings
        {
            get => new ExportSettings(Obj.Settings);
            set => Obj.Settings = ((ExportSettings)value).Obj;
        }

        public IDocumentsQuery Source
        {
            get => new DocumentsQuery(Obj.Source);
            set => Obj.Source = ((DocumentsQuery)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
