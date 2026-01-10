using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class User(DocuWare.Platform.ServerClient.User obj) : IUser
    {
        internal DocuWare.Platform.ServerClient.User Obj { get; } = obj;

        public string EMail
        {
            get => Obj.EMail;
            set => Obj.EMail = value;
        }

        public string DefaultWebBasket
        {
            get => Obj.DefaultWebBasket;
            set => Obj.DefaultWebBasket = value;
        }

        public IOutOfOffice OutOfOffice
        {
            get => new OutOfOffice(Obj.OutOfOffice);
            set => Obj.OutOfOffice = ((OutOfOffice)value).Obj;
        }

        public IRegionalSettings RegionalSettings
        {
            get => new RegionalSettings(Obj.RegionalSettings);
            set => Obj.RegionalSettings = ((RegionalSettings)value).Obj;
        }

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

        public string FirstName
        {
            get => Obj.FirstName;
            set => Obj.FirstName = value;
        }

        public string LastName
        {
            get => Obj.LastName;
            set => Obj.LastName = value;
        }

        public string Salutation
        {
            get => Obj.Salutation;
            set => Obj.Salutation = value;
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }

        public bool Active
        {
            get => Obj.Active;
            set => Obj.Active = value;
        }

        public string NetworkId
        {
            get => Obj.NetworkId;
            set => Obj.NetworkId = value;
        }

        public string ExternalId
        {
            get => Obj.ExternalId;
            set => Obj.ExternalId = value;
        }

        public string ExternalProvider
        {
            get => Obj.ExternalProvider;
            set => Obj.ExternalProvider = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IUser GetUserFromSelfRelation() => new User(Obj.GetUserFromSelfRelation());

        public async Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.GetUserFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.GetUserFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IUser PostToSelfRelationForUser(IUser dataToSend) => new User(Obj.PostToSelfRelationForUser(((User)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToSelfRelationForUserAsync(((User)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToSelfRelationForUserAsync(cancellationToken, ((User)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IFileCabinet GetFileCabinetFromDefaultWebBasketRelation() => new FileCabinet(Obj.GetFileCabinetFromDefaultWebBasketRelation());

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromDefaultWebBasketRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromDefaultWebBasketRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public IGroups GetGroupsFromGroupsRelation() => new Groups(Obj.GetGroupsFromGroupsRelation());

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.GetGroupsFromGroupsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.GetGroupsFromGroupsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

		public string PutToGroupsRelationForString(IAssignmentOperation dataToSend) => Obj.PutToGroupsRelationForString(((AssignmentOperation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(IAssignmentOperation dataToSend) => await Obj.PutToGroupsRelationForStringAsync(((AssignmentOperation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend) => await Obj.PutToGroupsRelationForStringAsync(cancellationToken, ((AssignmentOperation)dataToSend).Obj);

        public IRoles GetRolesFromRolesRelation() => new Roles(Obj.GetRolesFromRolesRelation());

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.GetRolesFromRolesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.GetRolesFromRolesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

		public string PutToRolesRelationForString(IAssignmentOperation dataToSend) => Obj.PutToRolesRelationForString(((AssignmentOperation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(IAssignmentOperation dataToSend) => await Obj.PutToRolesRelationForStringAsync(((AssignmentOperation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend) => await Obj.PutToRolesRelationForStringAsync(cancellationToken, ((AssignmentOperation)dataToSend).Obj);
    }
}
