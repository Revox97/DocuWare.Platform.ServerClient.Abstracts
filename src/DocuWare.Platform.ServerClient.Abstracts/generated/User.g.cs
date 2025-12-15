using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class User(SDK.User obj) : IUser
    {
        internal SDK.User Obj { get; } = obj;

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

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string DefaultWebBasketRelationLink => Obj.DefaultWebBasketRelationLink;

        public string GroupsRelationLink => Obj.GroupsRelationLink;

        public string RolesRelationLink => Obj.RolesRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IUser GetUserFromSelfRelation() => new User(Obj.GetUserFromSelfRelation());

        public async Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.GetUserFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.GetUserFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IUser PostToSelfRelationForUser(IUser dataToSend) => new User(Obj.PostToSelfRelationForUser(dataToSend));

        public async Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(IUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToSelfRelationForUserAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToSelfRelationForUserAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IFileCabinet GetFileCabinetFromDefaultWebBasketRelation() => new FileCabinet(Obj.GetFileCabinetFromDefaultWebBasketRelation());

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync()
        {
            DocuWare.Platform.ServerClient.IFileCabinet result = await Obj.GetFileCabinetFromDefaultWebBasketRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IFileCabinet result = await Obj.GetFileCabinetFromDefaultWebBasketRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public IGroups GetGroupsFromGroupsRelation() => new Groups(Obj.GetGroupsFromGroupsRelation());

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.GetGroupsFromGroupsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.GetGroupsFromGroupsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

		public async string PutToGroupsRelationForString(IAssignmentOperation dataToSend) => Obj.PutToGroupsRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(IAssignmentOperation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToGroupsRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToGroupsRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IRoles GetRolesFromRolesRelation() => new Roles(Obj.GetRolesFromRolesRelation());

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.GetRolesFromRolesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.GetRolesFromRolesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

		public async string PutToRolesRelationForString(IAssignmentOperation dataToSend) => Obj.PutToRolesRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(IAssignmentOperation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToRolesRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToRolesRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }
    }
}
