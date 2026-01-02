using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinets(DocuWare.Platform.ServerClient.FileCabinets obj) : IFileCabinets
    {
        internal DocuWare.Platform.ServerClient.FileCabinets Obj { get; } = obj;

        public List<IFileCabinet> FileCabinet
        {
            get => Obj.FileCabinet.Select(x => new FileCabinet(x) as IFileCabinet).ToList();
            set => Obj.FileCabinet = value.Select(x => ((FileCabinet)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
