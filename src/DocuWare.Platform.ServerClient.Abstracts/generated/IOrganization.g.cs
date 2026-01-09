using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganization{3}
    {
		Link[] Links { get; set; }
		List<ConfigurationRight> ConfigurationRights { get; set; }
		IExtendedConfigurationRights ExtendedConfigurationRights { get; set; }
		string Name { get; set; }
		string Id { get; set; }
		string Guid { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IFileCabinets GetFileCabinetsFromFilecabinetsRelation();
		Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync();
		Task<DeserializedHttpResponse<IFileCabinets>> GetFileCabinetsFromFilecabinetsRelationAsync(CancellationToken cancellationToken);
		IUsers GetUsersFromUsersRelation();
		Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync();
		Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync(CancellationToken cancellationToken);
		IUsers PostToUsersRelationForUsers(IUsersQuery dataToSend);
		Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersQuery dataToSend);
		Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersQuery dataToSend);
		IGroups PostToUsersRelationForGroups(IUserGroupsQuery dataToSend);
		Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(IUserGroupsQuery dataToSend);
		Task<DeserializedHttpResponse<IGroups>> PostToUsersRelationForGroupsAsync(CancellationToken cancellationToken, IUserGroupsQuery dataToSend);
		IRoles PostToUsersRelationForRoles(IUserRolesQuery dataToSend);
		Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(IUserRolesQuery dataToSend);
		Task<DeserializedHttpResponse<IRoles>> PostToUsersRelationForRolesAsync(CancellationToken cancellationToken, IUserRolesQuery dataToSend);
		IUsers PostToUsersRelationForUsers(IUsersByRole dataToSend);
		Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(IUsersByRole dataToSend);
		Task<DeserializedHttpResponse<IUsers>> PostToUsersRelationForUsersAsync(CancellationToken cancellationToken, IUsersByRole dataToSend);
		IRoles GetRolesFromRolesRelation();
		Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync();
		Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync(CancellationToken cancellationToken);
		IRoles PostToRolesRelationForRoles(IRolesQuery dataToSend);
		Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(IRolesQuery dataToSend);
		Task<DeserializedHttpResponse<IRoles>> PostToRolesRelationForRolesAsync(CancellationToken cancellationToken, IRolesQuery dataToSend);
		IGroups GetGroupsFromGroupsRelation();
		Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync();
		Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync(CancellationToken cancellationToken);
		IGroups PostToGroupsRelationForGroups(IGroupsQuery dataToSend);
		Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(IGroupsQuery dataToSend);
		Task<DeserializedHttpResponse<IGroups>> PostToGroupsRelationForGroupsAsync(CancellationToken cancellationToken, IGroupsQuery dataToSend);
		IGroup PostToCreateGroupRelationForGroup(IGroup dataToSend);
		Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(IGroup dataToSend);
		Task<DeserializedHttpResponse<IGroup>> PostToCreateGroupRelationForGroupAsync(CancellationToken cancellationToken, IGroup dataToSend);
		ISelectListInfos GetSelectListInfosFromSelectListInfosRelation();
		Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync();
		Task<DeserializedHttpResponse<ISelectListInfos>> GetSelectListInfosFromSelectListInfosRelationAsync(CancellationToken cancellationToken);
		IMultiColSelectListInfos GetMultiColSelectListInfosFromMultiColSelectListInfosRelation();
		Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync();
		Task<DeserializedHttpResponse<IMultiColSelectListInfos>> GetMultiColSelectListInfosFromMultiColSelectListInfosRelationAsync(CancellationToken cancellationToken);
		IOrganization GetOrganizationFromSelfRelation();
		Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IOrganization>> GetOrganizationFromSelfRelationAsync(CancellationToken cancellationToken);
		string PostToLoginTokenRelationForString(ITokenDescription dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(ITokenDescription dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLoginTokenRelationForStringAsync(CancellationToken cancellationToken, ITokenDescription dataToSend);
		IDialogInfos GetDialogInfosFromDialogsRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken);
		IDialogInfos PostToDialogsRelationForDialogInfos(IRequestDialogQuery dataToSend);
		Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(IRequestDialogQuery dataToSend);
		Task<DeserializedHttpResponse<IDialogInfos>> PostToDialogsRelationForDialogInfosAsync(CancellationToken cancellationToken, IRequestDialogQuery dataToSend);
		IUserInfo GetUserInfoFromUserInfoRelation();
		Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync();
		Task<DeserializedHttpResponse<IUserInfo>> GetUserInfoFromUserInfoRelationAsync(CancellationToken cancellationToken);
		IUser PostToUserInfoRelationForUser(IUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(IUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend);
		IUser PostToUserInfoRelationForUser(INewUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(INewUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToUserInfoRelationForUserAsync(CancellationToken cancellationToken, INewUser dataToSend);
		IWorkflows GetWorkflowsFromWorkflowsRelation();
		Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync();
		Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromWorkflowsRelationAsync(CancellationToken cancellationToken);
		IWorkflows GetWorkflowsFromControllerWorkflowsRelation();
		Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync();
		Task<DeserializedHttpResponse<IWorkflows>> GetWorkflowsFromControllerWorkflowsRelationAsync(CancellationToken cancellationToken);
		IDesignerWorkflows GetDesignerWorkflowsFromDesignerWorkflowsRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflows>> GetDesignerWorkflowsFromDesignerWorkflowsRelationAsync(CancellationToken cancellationToken);
		IWorkflowRequests GetWorkflowRequestsFromWorkflowRequestsRelation();
		Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowRequests>> GetWorkflowRequestsFromWorkflowRequestsRelationAsync(CancellationToken cancellationToken);
		string PostToWorkflowRequestsRelationForString(IRequestSettings dataToSend);
		Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(IRequestSettings dataToSend);
		Task<DeserializedHttpResponse<string>> PostToWorkflowRequestsRelationForStringAsync(CancellationToken cancellationToken, IRequestSettings dataToSend);
		ISubstitutionLists GetSubstitutionListsFromSubstitutionListsRelation();
		Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync();
		Task<DeserializedHttpResponse<ISubstitutionLists>> GetSubstitutionListsFromSubstitutionListsRelationAsync(CancellationToken cancellationToken);
		ITrashBin GetTrashBinFromTrashBinRelation();
		Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync();
		Task<DeserializedHttpResponse<ITrashBin>> GetTrashBinFromTrashBinRelationAsync(CancellationToken cancellationToken);
    }
}
