using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingFiles(SDK.AdhocRenderingFiles obj) : IAdhocRenderingFiles
    {
        internal SDK.AdhocRenderingFiles Obj { get; } = obj;

		public List<IAdhocRenderingFile> Item
		{
			get => Obj.Item.Select(x => new AdhocRenderingFile(x) as IAdhocRenderingFile).ToList();
			set => Obj.Item = value.Select(x => ((AdhocRenderingFile)x).Obj).ToList();
		}

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
