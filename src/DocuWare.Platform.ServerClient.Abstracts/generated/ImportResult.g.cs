using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportResult(SDK.ImportResult obj) : IImportResult
    {
        internal SDK.ImportResult Obj { get; } = obj;

        public List<IImportResultEntry> Results
        {
            get => Obj.Results.Select(x => new ImportResultEntry(x) as IImportResultEntry).ToList();
            set => Obj.Results = value.Select(x => ((ImportResultEntry)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
