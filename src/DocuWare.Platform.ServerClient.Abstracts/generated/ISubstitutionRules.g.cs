using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionRules
    {
		List<ISubstitutionRule> Item { get; set; }
    }
}
