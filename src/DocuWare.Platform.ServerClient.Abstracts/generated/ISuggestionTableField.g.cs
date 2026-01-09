using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionTableField{3}
    {
		List<ISuggestionTable> Table { get; set; }
		string DBName { get; set; }
		IntellixFieldTrust Confidence { get; set; }
    }
}
