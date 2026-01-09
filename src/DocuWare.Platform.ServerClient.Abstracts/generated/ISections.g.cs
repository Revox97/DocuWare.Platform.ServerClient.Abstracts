using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISections{3}
    {
		List<ISection> Section { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
