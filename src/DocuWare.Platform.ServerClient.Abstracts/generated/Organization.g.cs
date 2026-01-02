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

        public List<DocuWare.Platform.ServerClient.ConfigurationRight> ConfigurationRights
        {
            get => Obj.ConfigurationRights;
            set => Obj.ConfigurationRights = value;
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

        public FileCabinets GetFileCabinetsFromFilecabinetsRelation() => new FileCabinets(Obj.GetFileCabinetsFromFilecabinetsRelation());

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinets> result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FileCabinets>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinets> result = await Obj.GetFileCabinetsFromFilecabinetsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinets(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FileCabinets>(temp).ConfigureAwait(false);
        }

        public Users GetUsersFromUsersRelation() => new Users(Obj.GetUsersFromUsersRelation());

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.GetUsersFromUsersRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.GetUsersFromUsersRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public Users PostToUsersRelationForUsers(IUsersQuery dataToSend) => new Users(Obj.PostToUsersRelationForUsers(dataToSend));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public Groups PostToUsersRelationForGroups(IUserGroupsQuery dataToSend) => new Groups(Obj.PostToUsersRelationForGroups(dataToSend));

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(IUserGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToUsersRelationForGroupsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(CancellationToken cancellationToken, IUserGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToUsersRelationForGroupsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public Roles PostToUsersRelationForRoles(IUserRolesQuery dataToSend) => new Roles(Obj.PostToUsersRelationForRoles(dataToSend));

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(IUserRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToUsersRelationForRolesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(CancellationToken cancellationToken, IUserRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToUsersRelationForRolesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public Users PostToUsersRelationForUsers(IUsersByRole dataToSend) => new Users(Obj.PostToUsersRelationForUsers(dataToSend));

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersByRole dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersByRole dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Users> result = await Obj.PostToUsersRelationForUsersAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Users(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Users>(temp).ConfigureAwait(false);
        }

        public Roles GetRolesFromRolesRelation() => new Roles(Obj.GetRolesFromRolesRelation());

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.GetRolesFromRolesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.GetRolesFromRolesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public Roles PostToRolesRelationForRoles(IRolesQuery dataToSend) => new Roles(Obj.PostToRolesRelationForRoles(dataToSend));

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(IRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToRolesRelationForRolesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(CancellationToken cancellationToken, IRolesQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Roles> result = await Obj.PostToRolesRelationForRolesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Roles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Roles>(temp).ConfigureAwait(false);
        }

        public Groups GetGroupsFromGroupsRelation() => new Groups(Obj.GetGroupsFromGroupsRelation());

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.GetGroupsFromGroupsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.GetGroupsFromGroupsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public Groups PostToGroupsRelationForGroups(IGroupsQuery dataToSend) => new Groups(Obj.PostToGroupsRelationForGroups(dataToSend));

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(IGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToGroupsRelationForGroupsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(CancellationToken cancellationToken, IGroupsQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Groups> result = await Obj.PostToGroupsRelationForGroupsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Groups(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Groups>(temp).ConfigureAwait(false);
        }

        public Group PostToCreateGroupRelationForGroup(IGroup dataToSend) => new Group(Obj.PostToCreateGroupRelationForGroup(dataToSend));

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(IGroup dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.PostToCreateGroupRelationForGroupAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Group>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(CancellationToken cancellationToken, IGroup dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Group> result = await Obj.PostToCreateGroupRelationForGroupAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Group(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Group>(temp).ConfigureAwait(false);
        }

        public SelectListInfos GetSelectListInfosFromSelectListInfosRelation() => new SelectListInfos(Obj.GetSelectListInfosFromSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListInfos> result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SelectListInfos> result = await Obj.GetSelectListInfosFromSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SelectListInfos>(temp).ConfigureAwait(false);
        }

        public MultiColSelectListInfos GetMultiColSelectListInfosFromMultiColSelectListInfosRelation() => new MultiColSelectListInfos(Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListInfos> result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<MultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.MultiColSelectListInfos> result = await Obj.GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new MultiColSelectListInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<MultiColSelectListInfos>(temp).ConfigureAwait(false);
        }

        public Organization GetOrganizationFromSelfRelation() => new Organization(Obj.GetOrganizationFromSelfRelation());

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organization> result = await Obj.GetOrganizationFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Organization>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organization> result = await Obj.GetOrganizationFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organization(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Organization>(temp).ConfigureAwait(false);
        }

		public async string PostToLoginTokenRelationForString(ITokenDescription dataToSend) => Obj.PostToLoginTokenRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(ITokenDescription dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLoginTokenRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(CancellationToken cancellationToken, ITokenDescription dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLoginTokenRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public DialogInfos PostToDialogsRelationForDialogInfos(IRequestDialogQuery dataToSend) => new DialogInfos(Obj.PostToDialogsRelationForDialogInfos(dataToSend));

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(IRequestDialogQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.PostToDialogsRelationForDialogInfosAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(CancellationToken cancellationToken, IRequestDialogQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.PostToDialogsRelationForDialogInfosAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public UserInfo GetUserInfoFromUserInfoRelation() => new UserInfo(Obj.GetUserInfoFromUserInfoRelation());

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.UserInfo> result = await Obj.GetUserInfoFromUserInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new UserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<UserInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.UserInfo> result = await Obj.GetUserInfoFromUserInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new UserInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<UserInfo>(temp).ConfigureAwait(false);
        }

        public User PostToUserInfoRelationForUser(IUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(dataToSend));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<User>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<User>(temp).ConfigureAwait(false);
        }

        public User PostToUserInfoRelationForUser(INewUser dataToSend) => new User(Obj.PostToUserInfoRelationForUser(dataToSend));

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(INewUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<User>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, INewUser dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.User> result = await Obj.PostToUserInfoRelationForUserAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new User(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<User>(temp).ConfigureAwait(false);
        }

        public Workflows GetWorkflowsFromWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Workflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Workflows>(temp).ConfigureAwait(false);
        }

        public Workflows GetWorkflowsFromControllerWorkflowsRelation() => new Workflows(Obj.GetWorkflowsFromControllerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Workflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Workflows> result = await Obj.GetWorkflowsFromControllerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Workflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Workflows>(temp).ConfigureAwait(false);
        }

        public DesignerWorkflows GetDesignerWorkflowsFromDesignerWorkflowsRelation() => new DesignerWorkflows(Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelation());

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflows> result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DesignerWorkflows> result = await Obj.GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DesignerWorkflows(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DesignerWorkflows>(temp).ConfigureAwait(false);
        }

        public WorkflowRequests GetWorkflowRequestsFromWorkflowRequestsRelation() => new WorkflowRequests(Obj.GetWorkflowRequestsFromWorkflowRequestsRelation());

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowRequests> result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowRequests>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowRequests> result = await Obj.GetWorkflowRequestsFromWorkflowRequestsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowRequests(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowRequests>(temp).ConfigureAwait(false);
        }

		public async string PostToWorkflowRequestsRelationForString(IRequestSettings dataToSend) => Obj.PostToWorkflowRequestsRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(IRequestSettings dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToWorkflowRequestsRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(CancellationToken cancellationToken, IRequestSettings dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToWorkflowRequestsRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public SubstitutionLists GetSubstitutionListsFromSubstitutionListsRelation() => new SubstitutionLists(Obj.GetSubstitutionListsFromSubstitutionListsRelation());

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SubstitutionLists> result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SubstitutionLists>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SubstitutionLists> result = await Obj.GetSubstitutionListsFromSubstitutionListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SubstitutionLists(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SubstitutionLists>(temp).ConfigureAwait(false);
        }

        public TrashBin GetTrashBinFromTrashBinRelation() => new TrashBin(Obj.GetTrashBinFromTrashBinRelation());

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBin> result = await Obj.GetTrashBinFromTrashBinRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBin>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TrashBin> result = await Obj.GetTrashBinFromTrashBinRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TrashBin(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TrashBin>(temp).ConfigureAwait(false);
        }
    }
}
