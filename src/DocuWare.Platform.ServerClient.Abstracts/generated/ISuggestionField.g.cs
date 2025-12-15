using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionField
    {
		List<ISuggestionValue> Value { get; set; }
		string Name { get; set; }
		string DBName { get; set; }
		DocuWare.Platform.ServerClient.IntellixFieldTrust Confidence { get; set; }
    }
}
