using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionFields
    {
		List<ISuggestionField> Field { get; set; }
    }
}
