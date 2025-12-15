using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionList
    {
		Link[] Links { get; set; }
		string Name { get; set; }
		bool Active { get; set; }
		string Guid { get; set; }
		string SubstitutionRulesRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		ISubstitutionRules GetSubstitutionRulesFromSubstitutionRulesRelation();
		Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync();
		Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync(CancellationToken cancellationToken);
    }
}
