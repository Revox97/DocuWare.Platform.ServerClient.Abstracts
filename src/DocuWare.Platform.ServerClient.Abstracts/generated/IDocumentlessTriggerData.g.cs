using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentlessTriggerData
    {
		List<ITriggerVariable> TextVariables { get; set; }
		List<ITriggerVariable> DecimalVariables { get; set; }
		List<ITriggerVariable> DateTimeVariables { get; set; }
		List<ITriggerVariable> DateVariables { get; set; }
		List<ITriggerVariable> UserVariables { get; set; }
		List<ITriggerVariable> MultiUserVariables { get; set; }
		List<ITriggerVariable> RoleVariables { get; set; }
		List<ITriggerVariable> MultiRoleVariables { get; set; }
		List<ITriggerVariable> SubstitutionRuleVariables { get; set; }
		List<ITriggerVariable> MultiSubstitutionRuleVariables { get; set; }
		List<ITriggerVariable> KeywordVariables { get; set; }
		string ExpectedDefinitionId { get; set; }
    }
}
