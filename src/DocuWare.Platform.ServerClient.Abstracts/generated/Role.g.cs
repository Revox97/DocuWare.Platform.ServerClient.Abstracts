using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Role(SDK.Role obj) : IRole
    {
        internal SDK.Role Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
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

        public RoleTypes Type
        {
            get => (RoleTypes)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.RoleTypes)value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IRole GetRoleFromSelfRelation() => new Role(Obj.GetRoleFromSelfRelation());

        public async Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Role> result = await Obj.GetRoleFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Role(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRole>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Role> result = await Obj.GetRoleFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Role(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRole>(temp).ConfigureAwait(false);
        }
    }
}
