using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionLists{3}
    {
		List<ISubstitutionList> Item { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
