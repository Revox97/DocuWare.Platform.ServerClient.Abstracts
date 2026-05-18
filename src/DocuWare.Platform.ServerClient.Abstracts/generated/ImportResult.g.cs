using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

        public IUploadedFileChunk FileChunk
        {
            get => new UploadedFileChunk(Obj.FileChunk);
            set => Obj.FileChunk = ((UploadedFileChunk)value).Obj;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
