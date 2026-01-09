using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeListComplexType
    {
		XElementWrapper Any { get; set; }
		string IntroducedIn { get; set; }
    }
}
