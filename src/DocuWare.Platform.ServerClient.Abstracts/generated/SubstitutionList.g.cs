using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubstitutionList(SDK.SubstitutionList obj) : ISubstitutionList
    {
        internal SDK.SubstitutionList Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public bool Active
		{
			get => Obj.Active;
			set => Obj.Active = value;
		}

		public string Guid
		{
			get => Obj.Guid;
			set => Obj.Guid = value;
		}

		public string SubstitutionRulesRelationLink => Obj.SubstitutionRulesRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public ISubstitutionRules GetSubstitutionRulesFromSubstitutionRulesRelation() => new SubstitutionRules(Obj.GetSubstitutionRulesFromSubstitutionRulesRelation());

        public async Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISubstitutionRules result = await Obj.GetSubstitutionRulesFromSubstitutionRulesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISubstitutionRules(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionRules>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISubstitutionRules>> GetSubstitutionRulesFromSubstitutionRulesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISubstitutionRules result = await Obj.GetSubstitutionRulesFromSubstitutionRulesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISubstitutionRules(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionRules>(temp).ConfigureAwait(false);
        }

    }
}
