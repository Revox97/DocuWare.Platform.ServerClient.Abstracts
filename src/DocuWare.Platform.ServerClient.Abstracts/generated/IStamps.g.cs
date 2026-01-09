using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStamps
    {
		List<IStamp> Stamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
