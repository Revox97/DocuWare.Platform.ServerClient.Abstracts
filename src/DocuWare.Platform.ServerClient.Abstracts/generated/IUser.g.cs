using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUser
    {
		string EMail { get; set; }
		string DefaultWebBasket { get; set; }
		IOutOfOffice OutOfOffice { get; set; }
		IRegionalSettings RegionalSettings { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Salutation { get; set; }
		string DBName { get; set; }
		bool Active { get; set; }
		string NetworkId { get; set; }
		string ExternalId { get; set; }
		string ExternalProvider { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IUser GetUserFromSelfRelation();
		Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IUser>> GetUserFromSelfRelationAsync(CancellationToken cancellationToken);
		IUser PostToSelfRelationForUser(IUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(IUser dataToSend);
		Task<DeserializedHttpResponse<IUser>> PostToSelfRelationForUserAsync(CancellationToken cancellationToken, IUser dataToSend);
		IFileCabinet GetFileCabinetFromDefaultWebBasketRelation();
		Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync();
		Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromDefaultWebBasketRelationAsync(CancellationToken cancellationToken);
		IGroups GetGroupsFromGroupsRelation();
		Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync();
		Task<DeserializedHttpResponse<IGroups>> GetGroupsFromGroupsRelationAsync(CancellationToken cancellationToken);
		string PutToGroupsRelationForString(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToGroupsRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend);
		IRoles GetRolesFromRolesRelation();
		Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync();
		Task<DeserializedHttpResponse<IRoles>> GetRolesFromRolesRelationAsync(CancellationToken cancellationToken);
		string PutToRolesRelationForString(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToRolesRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend);
    }
}
