using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Group(SDK.Group obj) : IGroup
    {
        internal SDK.Group Obj { get; } = obj;

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

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string UsersRelationLink => Obj.UsersRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IGroup GetGroupFromSelfRelation() => new Group(Obj.GetGroupFromSelfRelation());

        public async Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IGroup result = await Obj.GetGroupFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroup(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IGroup result = await Obj.GetGroupFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroup(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public IUsers GetUsersFromUsersRelation() => new Users(Obj.GetUsersFromUsersRelation());

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync()
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.GetUsersFromUsersRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.GetUsersFromUsersRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

    }
}
