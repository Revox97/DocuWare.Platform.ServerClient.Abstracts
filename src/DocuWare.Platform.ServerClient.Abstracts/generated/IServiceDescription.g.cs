using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceDescription{3}
    {
		Link[] Links { get; set; }
		List<UriTemplateDescription> Resources { get; set; }
		string Version { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IOrganizations GetOrganizationsFromOrganizationsRelation();
		Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync();
		Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromLoginRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync(CancellationToken cancellationToken);
		Stream PostToLoginRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromGuestLoginRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync(CancellationToken cancellationToken);
		Stream PostToGuestLoginRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		string GetStringFromWindowsLoginRelation();
		Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync();
		Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync(CancellationToken cancellationToken);
		string PostToWindowsLoginRelationForString(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromChangePasswordRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync(CancellationToken cancellationToken);
		Stream PostToChangePasswordRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromResetPasswordRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync(CancellationToken cancellationToken);
		Stream PostToResetPasswordRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromTokenLoginRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync(CancellationToken cancellationToken);
		Stream PostToTokenLoginRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromTrustedLoginRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync(CancellationToken cancellationToken);
		Stream PostToTrustedLoginRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream PostToJwtLoginRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromLogoutRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDisconnectRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync(CancellationToken cancellationToken);
		string GetStringFromLoginCookieRelation();
		Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync();
		Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync(CancellationToken cancellationToken);
		IAdhocRenderingFiles GetAdhocRenderingFilesFromAdhocRenderingRelation();
		Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync();
		Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync(CancellationToken cancellationToken);
		IAdhocRenderingFile PostToAdhocRenderingRelationForAdhocRenderingFile(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		Stream GetStreamFromRootSchemaRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync(CancellationToken cancellationToken);
		string GetStringFromPermanentUrlRelation();
		Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync();
		Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync(CancellationToken cancellationToken);
		IIdentityServiceInfo GetIdentityServiceInfoFromIdentityServiceInfoRelation();
		Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync();
		Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync(CancellationToken cancellationToken);
    }
}
