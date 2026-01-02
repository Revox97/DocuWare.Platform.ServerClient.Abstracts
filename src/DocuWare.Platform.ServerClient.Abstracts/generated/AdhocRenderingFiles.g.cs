using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingFiles(DocuWare.Platform.ServerClient.AdhocRenderingFiles obj) : IAdhocRenderingFiles
    {
        internal DocuWare.Platform.ServerClient.AdhocRenderingFiles Obj { get; } = obj;

        public List<IAdhocRenderingFile> Item
        {
            get => Obj.Item.Select(x => new AdhocRenderingFile(x) as IAdhocRenderingFile).ToList();
            set => Obj.Item = value.Select(x => ((AdhocRenderingFile)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
