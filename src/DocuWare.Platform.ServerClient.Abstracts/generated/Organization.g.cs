using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Organization(SDK.Organization obj) : IOrganization
    {
        internal SDK.Organization Obj { get; } = obj;

		public IAdditionalOrganizationInfo AdditionalInfo
		{
			get => new AdditionalOrganizationInfo(Obj.AdditionalInfo);
			set => Obj.AdditionalInfo = ((AdditionalOrganizationInfo)value).Obj;
		}

		public ICalendar Calendar
		{
			get => new Calendar(Obj.Calendar);
			set => Obj.Calendar = ((Calendar)value).Obj;
		}

		public IOrganizationCulture Culture
		{
			get => new OrganizationCulture(Obj.Culture);
			set => Obj.Culture = ((OrganizationCulture)value).Obj;
		}

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public List<ConfigurationRight> ConfigurationRights
		{
			get => Obj.ConfigurationRights.Select(x => new onfigurationRight(x) as ConfigurationRight).ToList();
			set => Obj.ConfigurationRights = value.Select(x => ((onfigurationRight)x).Obj).ToList();
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

		public string FilecabinetsRelationLink => Obj.FilecabinetsRelationLink;

		public string UsersRelationLink => Obj.UsersRelationLink;

		public string RolesRelationLink => Obj.RolesRelationLink;

		public string GroupsRelationLink => Obj.GroupsRelationLink;

		public string CreateGroupRelationLink => Obj.CreateGroupRelationLink;

		public string SelectListInfosRelationLink => Obj.SelectListInfosRelationLink;

		public string MultiColSelectListInfosRelationLink => Obj.MultiColSelectListInfosRelationLink;

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string LoginTokenRelationLink => Obj.LoginTokenRelationLink;

		public string DialogsRelationLink => Obj.DialogsRelationLink;

		public string UserInfoRelationLink => Obj.UserInfoRelationLink;

		public string WorkflowsRelationLink => Obj.WorkflowsRelationLink;

		public string ControllerWorkflowsRelationLink => Obj.ControllerWorkflowsRelationLink;

		public string DesignerWorkflowsRelationLink => Obj.DesignerWorkflowsRelationLink;

		public string WorkflowRequestsRelationLink => Obj.WorkflowRequestsRelationLink;

		public string SubstitutionListsRelationLink => Obj.SubstitutionListsRelationLink;

		public string TrashBinRelationLink => Obj.TrashBinRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IFileCabinets GetFileCabinetsFromFilecabinetsRelation() => new FileCabinets(Obj.GetFileCabinetsFromFilecabinetsRelation());

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IFileCabinets result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinets>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IFileCabinets result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinets>(temp).ConfigureAwait(false);
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

        public IUsers PostToUsersRelationForUsers(IUsersQuery dataToSend) => new Users(Obj.PostToUsersRelationForUsers(dataToSend));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.PostToUsersRelationForUsersAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public IGroups PostToUsersRelationForGroups(IUserGroupsQuery dataToSend) => new Groups(Obj.PostToUsersRelationForGroups(dataToSend));

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(IUserGroupsQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.PostToUsersRelationForGroupsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(CancellationToken cancellationToken, IUserGroupsQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.PostToUsersRelationForGroupsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public IRoles PostToUsersRelationForRoles(IUserRolesQuery dataToSend) => new Roles(Obj.PostToUsersRelationForRoles(dataToSend));

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(IUserRolesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.PostToUsersRelationForRolesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(CancellationToken cancellationToken, IUserRolesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.PostToUsersRelationForRolesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public IUsers PostToUsersRelationForUsers(IUsersByRole dataToSend) => new Users(Obj.PostToUsersRelationForUsers(dataToSend));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersByRole dataToSend)
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.PostToUsersRelationForUsersAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersByRole dataToSend)
        {
            DocuWare.Platform.ServerClient.IUsers result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUsers(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUsers>(temp).ConfigureAwait(false);
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

        public IRoles PostToRolesRelationForRoles(IRolesQuery dataToSend) => new Roles(Obj.PostToRolesRelationForRoles(dataToSend));

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(IRolesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.PostToRolesRelationForRolesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(CancellationToken cancellationToken, IRolesQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IRoles result = await Obj.PostToRolesRelationForRolesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRoles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRoles>(temp).ConfigureAwait(false);
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

        public IGroups PostToGroupsRelationForGroups(IGroupsQuery dataToSend) => new Groups(Obj.PostToGroupsRelationForGroups(dataToSend));

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(IGroupsQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.PostToGroupsRelationForGroupsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(CancellationToken cancellationToken, IGroupsQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroups result = await Obj.PostToGroupsRelationForGroupsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroups>(temp).ConfigureAwait(false);
        }

        public IGroup PostToCreateGroupRelationForGroup(IGroup dataToSend) => new Group(Obj.PostToCreateGroupRelationForGroup(dataToSend));

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(IGroup dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroup result = await Obj.PostToCreateGroupRelationForGroupAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroup(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(CancellationToken cancellationToken, IGroup dataToSend)
        {
            DocuWare.Platform.ServerClient.IGroup result = await Obj.PostToCreateGroupRelationForGroupAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IGroup(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IGroup>(temp).ConfigureAwait(false);
        }

        public ISelectListInfos GetSelectListInfosFromSelectListInfosRelation() => new SelectListInfos(Obj.GetSelectListInfosFromSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListInfos result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListInfos result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListInfos>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListInfos GetMultiColSelectListInfosFromMultiColSelectListInfosRelation() => new MultiColSelectListInfos(Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListInfos result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListInfos result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public IOrganization GetOrganizationFromSelfRelation() => new Organization(Obj.GetOrganizationFromSelfRelation());

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IOrganization result = await Obj.GetOrganizationFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOrganization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganization>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IOrganization result = await Obj.GetOrganizationFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IOrganization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganization>(temp).ConfigureAwait(false);
        }

		public async string PostToLoginTokenRelationForString(ITokenDescription dataToSend) => Obj.PostToLoginTokenRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(ITokenDescription dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToLoginTokenRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(CancellationToken cancellationToken, ITokenDescription dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToLoginTokenRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos PostToDialogsRelationForDialogInfos(IRequestDialogQuery dataToSend) => new DialogInfos(Obj.PostToDialogsRelationForDialogInfos(dataToSend));

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(IRequestDialogQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.PostToDialogsRelationForDialogInfosAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(CancellationToken cancellationToken, IRequestDialogQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.PostToDialogsRelationForDialogInfosAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IUserInfo GetUserInfoFromUserInfoRelation() => new UserInfo(Obj.GetUserInfoFromUserInfoRelation());

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync()
        {
            DocuWare.Platform.ServerClient.IUserInfo result = await Obj.GetUserInfoFromUserInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUserInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IUserInfo result = await Obj.GetUserInfoFromUserInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUserInfo>(temp).ConfigureAwait(false);
        }

        public IUser PostToUserInfoRelationForUser(IUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(dataToSend));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(IUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToUserInfoRelationForUserAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IUser PostToUserInfoRelationForUser(INewUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(dataToSend));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(INewUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToUserInfoRelationForUserAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, INewUser dataToSend)
        {
            DocuWare.Platform.ServerClient.IUser result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IUser(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IUser>(temp).ConfigureAwait(false);
        }

        public IWorkflows GetWorkflowsFromWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflows result = await Obj.GetWorkflowsFromWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflows result = await Obj.GetWorkflowsFromWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflows GetWorkflowsFromControllerWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromControllerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflows result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflows result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflows>(temp).ConfigureAwait(false);
        }

        public IDesignerWorkflows GetDesignerWorkflowsFromDesignerWorkflowsRelation() => new DesignerWorkflows(Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflows result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDesignerWorkflows result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public IWorkflowRequests GetWorkflowRequestsFromWorkflowRequestsRelation() => new WorkflowRequests(Obj.GetWorkflowRequestsFromWorkflowRequestsRelation());

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowRequests result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowRequests>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowRequests result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowRequests>(temp).ConfigureAwait(false);
        }

		public async string PostToWorkflowRequestsRelationForString(IRequestSettings dataToSend) => Obj.PostToWorkflowRequestsRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(IRequestSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToWorkflowRequestsRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(CancellationToken cancellationToken, IRequestSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToWorkflowRequestsRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public ISubstitutionLists GetSubstitutionListsFromSubstitutionListsRelation() => new SubstitutionLists(Obj.GetSubstitutionListsFromSubstitutionListsRelation());

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISubstitutionLists result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionLists>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISubstitutionLists result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISubstitutionLists>(temp).ConfigureAwait(false);
        }

        public ITrashBin GetTrashBinFromTrashBinRelation() => new TrashBin(Obj.GetTrashBinFromTrashBinRelation());

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync()
        {
            DocuWare.Platform.ServerClient.ITrashBin result = await Obj.GetTrashBinFromTrashBinRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBin>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ITrashBin result = await Obj.GetTrashBinFromTrashBinRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ITrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITrashBin>(temp).ConfigureAwait(false);
        }

    }
}
