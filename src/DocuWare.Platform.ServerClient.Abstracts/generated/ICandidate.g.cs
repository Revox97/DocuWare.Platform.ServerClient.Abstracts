using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICandidate
    {
		object Item { get; set; }
		List<string> FoundWithLanguages { get; set; }
		List<string> CorrectLanguageTo { get; set; }
		List<string> ImpliesCultures { get; set; }
    }
}
