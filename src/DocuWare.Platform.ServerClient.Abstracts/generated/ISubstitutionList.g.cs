using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionList
    {
		Link[] Links { get; set; }
		string Name { get; set; }
		bool Active { get; set; }
		string Guid { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ISubstitutionRules GetSubstitutionRulesFromSubstitutionRulesRelation();
		Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync();
		Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync(CancellationToken cancellationToken);
    }
}
