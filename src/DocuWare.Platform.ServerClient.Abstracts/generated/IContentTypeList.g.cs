using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeList
    {
		List<object> Items { get; set; }
		string IntroducedIn { get; set; }
    }
}
