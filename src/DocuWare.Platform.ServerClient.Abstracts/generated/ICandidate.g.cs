using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICandidate
    {
		string Type { get; set; }
		string OriginalValue { get; set; }
		string FoundValue { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
		int Line { get; set; }
		int Index { get; set; }
		int Length { get; set; }
		object Item { get; set; }
		List<string> FoundWithLanguages { get; set; }
		List<string> CorrectLanguageTo { get; set; }
		List<string> ImpliesCultures { get; set; }
    }
}
