using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStamps{3}
    {
		List<IStamp> Stamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
