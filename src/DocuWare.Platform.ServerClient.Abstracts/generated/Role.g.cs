using SDK = DocuWare.Platform.ServerClient;

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

        public DocuWare.Platform.ServerClient.RoleTypes Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Role GetRoleFromSelfRelation() => new Role(Obj.GetRoleFromSelfRelation());

        public async Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Role> result = await Obj.GetRoleFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Role(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Role>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Role> result = await Obj.GetRoleFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Role(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Role>(temp).ConfigureAwait(false);
        }
    }
}
