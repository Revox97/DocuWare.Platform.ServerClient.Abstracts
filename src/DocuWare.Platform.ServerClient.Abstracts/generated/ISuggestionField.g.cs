using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionField{3}
    {
		List<ISuggestionValue> Value { get; set; }
		string Name { get; set; }
		string DBName { get; set; }
		IntellixFieldTrust Confidence { get; set; }
    }
}
