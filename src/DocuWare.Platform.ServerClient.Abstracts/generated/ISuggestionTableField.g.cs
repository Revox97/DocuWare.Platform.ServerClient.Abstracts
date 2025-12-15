using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionTableField
    {
		List<ISuggestionTable> Table { get; set; }
		string DBName { get; set; }
		DocuWare.Platform.ServerClient.IntellixFieldTrust Confidence { get; set; }
    }
}
