using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISuggestionTableFields
    {
		List<ISuggestionTableField> TableField { get; set; }
    }
}
