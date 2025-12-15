using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportQuery(SDK.ExportQuery obj) : IExportQuery
    {
        internal SDK.ExportQuery Obj { get; } = obj;

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

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
