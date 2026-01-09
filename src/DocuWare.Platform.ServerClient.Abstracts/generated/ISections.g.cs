using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISections
    {
		List<ISection> Section { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
