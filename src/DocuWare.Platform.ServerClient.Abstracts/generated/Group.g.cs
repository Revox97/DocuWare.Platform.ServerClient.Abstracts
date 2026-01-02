using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Group(DocuWare.Platform.ServerClient.Group obj) : IGroup
    {
        internal DocuWare.Platform.ServerClient.Group Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IGroup GetGroupFromSelfRelation() => new Group(Obj.GetGroupFromSelfRelation());

        public async Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.GetGroupFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.GetGroupFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public IUsers GetUsersFromUsersRelation() => new Users(Obj.GetUsersFromUsersRelation());

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.GetUsersFromUsersRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.GetUsersFromUsersRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }
    }
}
