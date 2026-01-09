using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinets
    {
		List<IFileCabinet> FileCabinet { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
