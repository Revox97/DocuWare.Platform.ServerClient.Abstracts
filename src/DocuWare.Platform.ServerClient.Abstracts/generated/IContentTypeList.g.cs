using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeList
    {
		List<Object> Items { get; set; }
		string IntroducedIn { get; set; }
    }
}
