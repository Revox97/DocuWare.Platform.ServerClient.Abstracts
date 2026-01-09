using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Organization(DocuWare.Platform.ServerClient.Organization obj) : IOrganization
    {
        internal DocuWare.Platform.ServerClient.Organization Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<ConfigurationRight> ConfigurationRights
        {
            get => Obj.ConfigurationRights.ConvertAll(o => (ConfigurationRight)o);
            set => Obj.ConfigurationRights = value.ConvertAll(v => (DocuWare.Platform.ServerClient.ConfigurationRight)v);
        }

        public IExtendedConfigurationRights ExtendedConfigurationRights
        {
            get => new ExtendedConfigurationRights(Obj.ExtendedConfigurationRights);
            set => Obj.ExtendedConfigurationRights = ((ExtendedConfigurationRights)value).Obj;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Guid
        {
            get => Obj.Guid;
            set => Obj.Guid = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IFileCabinets GetFileCabinetsFromFilecabinetsRelation() => new FileCabinets(Obj.GetFileCabinetsFromFilecabinetsRelation());

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinets> result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinets>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinets> result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinets>(temp).ConfigureAwait(false);
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

        public IUsers PostToUsersRelationForUsers(IUsersQuery dataToSend) => new Users(Obj.PostToUsersRelationForUsers(((UsersQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(((UsersQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, ((UsersQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public IGroups PostToUsersRelationForGroups(IUserGroupsQuery dataToSend) => new Groups(Obj.PostToUsersRelationForGroups(((UserGroupsQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(IUserGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToUsersRelationForGroupsAsync(((UserGroupsQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(CancellationToken cancellationToken, IUserGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToUsersRelationForGroupsAsync(cancellationToken, ((UserGroupsQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public IRoles PostToUsersRelationForRoles(IUserRolesQuery dataToSend) => new Roles(Obj.PostToUsersRelationForRoles(((UserRolesQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(IUserRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToUsersRelationForRolesAsync(((UserRolesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(CancellationToken cancellationToken, IUserRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToUsersRelationForRolesAsync(cancellationToken, ((UserRolesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public IUsers PostToUsersRelationForUsers(IUsersByRole dataToSend) => new Users(Obj.PostToUsersRelationForUsers(((UsersByRole)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersByRole dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(((UsersByRole)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersByRole dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, ((UsersByRole)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

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

        public IRoles PostToRolesRelationForRoles(IRolesQuery dataToSend) => new Roles(Obj.PostToRolesRelationForRoles(((RolesQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(IRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToRolesRelationForRolesAsync(((RolesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(CancellationToken cancellationToken, IRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToRolesRelationForRolesAsync(cancellationToken, ((RolesQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
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

        public IGroups PostToGroupsRelationForGroups(IGroupsQuery dataToSend) => new Groups(Obj.PostToGroupsRelationForGroups(((GroupsQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(IGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToGroupsRelationForGroupsAsync(((GroupsQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(CancellationToken cancellationToken, IGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToGroupsRelationForGroupsAsync(cancellationToken, ((GroupsQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public IGroup PostToCreateGroupRelationForGroup(IGroup dataToSend) => new Group(Obj.PostToCreateGroupRelationForGroup(((Group)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(IGroup dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.PostToCreateGroupRelationForGroupAsync(((Group)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(CancellationToken cancellationToken, IGroup dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.PostToCreateGroupRelationForGroupAsync(cancellationToken, ((Group)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public ISelectListInfos GetSelectListInfosFromSelectListInfosRelation() => new SelectListInfos(Obj.GetSelectListInfosFromSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListInfos> result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListInfos> result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListInfos>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListInfos GetMultiColSelectListInfosFromMultiColSelectListInfosRelation() => new MultiColSelectListInfos(Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListInfos> result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListInfos> result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public IOrganization GetOrganizationFromSelfRelation() => new Organization(Obj.GetOrganizationFromSelfRelation());

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organization> result = await Obj.GetOrganizationFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganization>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organization> result = await Obj.GetOrganizationFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganization>(temp).ConfigureAwait(false);
        }

		public string PostToLoginTokenRelationForString(ITokenDescription dataToSend) => Obj.PostToLoginTokenRelationForString(((TokenDescription)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(ITokenDescription dataToSend) => await Obj.PostToLoginTokenRelationForStringAsync(((TokenDescription)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(CancellationToken cancellationToken, ITokenDescription dataToSend) => await Obj.PostToLoginTokenRelationForStringAsync(cancellationToken, ((TokenDescription)dataToSend).Obj);

        public IDialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos PostToDialogsRelationForDialogInfos(IRequestDialogQuery dataToSend) => new DialogInfos(Obj.PostToDialogsRelationForDialogInfos(((RequestDialogQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(IRequestDialogQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.PostToDialogsRelationForDialogInfosAsync(((RequestDialogQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(CancellationToken cancellationToken, IRequestDialogQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.PostToDialogsRelationForDialogInfosAsync(cancellationToken, ((RequestDialogQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IUserInfo GetUserInfoFromUserInfoRelation() => new UserInfo(Obj.GetUserInfoFromUserInfoRelation());

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.UserInfo> result = await Obj.GetUserInfoFromUserInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new UserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUserInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.UserInfo> result = await Obj.GetUserInfoFromUserInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new UserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUserInfo>(temp).ConfigureAwait(false);
        }

        public IUser PostToUserInfoRelationForUser(IUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(((User)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(((User)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, ((User)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IUser PostToUserInfoRelationForUser(INewUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(((NewUser)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(INewUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(((NewUser)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, INewUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, ((NewUser)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IWorkflows GetWorkflowsFromWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflows GetWorkflowsFromControllerWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromControllerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public IDesignerWorkflows GetDesignerWorkflowsFromDesignerWorkflowsRelation() => new DesignerWorkflows(Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflows> result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflows> result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflowRequests GetWorkflowRequestsFromWorkflowRequestsRelation() => new WorkflowRequests(Obj.GetWorkflowRequestsFromWorkflowRequestsRelation());

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowRequests> result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowRequests>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowRequests> result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowRequests>(temp).ConfigureAwait(false);
        }

		public string PostToWorkflowRequestsRelationForString(IRequestSettings dataToSend) => Obj.PostToWorkflowRequestsRelationForString(((RequestSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(IRequestSettings dataToSend) => await Obj.PostToWorkflowRequestsRelationForStringAsync(((RequestSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(CancellationToken cancellationToken, IRequestSettings dataToSend) => await Obj.PostToWorkflowRequestsRelationForStringAsync(cancellationToken, ((RequestSettings)dataToSend).Obj);

        public ISubstitutionLists GetSubstitutionListsFromSubstitutionListsRelation() => new SubstitutionLists(Obj.GetSubstitutionListsFromSubstitutionListsRelation());

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SubstitutionLists> result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionLists>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SubstitutionLists> result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionLists>(temp).ConfigureAwait(false);
        }

        public ITrashBin GetTrashBinFromTrashBinRelation() => new TrashBin(Obj.GetTrashBinFromTrashBinRelation());

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBin> result = await Obj.GetTrashBinFromTrashBinRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBin>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBin> result = await Obj.GetTrashBinFromTrashBinRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBin>(temp).ConfigureAwait(false);
        }
    }
}
