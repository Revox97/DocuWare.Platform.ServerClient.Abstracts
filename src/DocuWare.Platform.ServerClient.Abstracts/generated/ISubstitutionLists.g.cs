using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionLists
    {
		List<ISubstitutionList> Item { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
