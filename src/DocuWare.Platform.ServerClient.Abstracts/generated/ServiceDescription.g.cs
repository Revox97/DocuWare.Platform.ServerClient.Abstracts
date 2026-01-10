using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescription(DocuWare.Platform.ServerClient.ServiceDescription obj) : IServiceDescription
    {
        internal DocuWare.Platform.ServerClient.ServiceDescription Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public IServiceDescriptionTests Tests
        {
            get => new ServiceDescriptionTests(Obj.Tests);
            set => Obj.Tests = ((ServiceDescriptionTests)value).Obj;
        }

        public IServiceDescriptionDocumentation Documentation
        {
            get => new ServiceDescriptionDocumentation(Obj.Documentation);
            set => Obj.Documentation = ((ServiceDescriptionDocumentation)value).Obj;
        }

        public List<UriTemplateDescription> Resources
        {
            get => Obj.Resources;
            set => Obj.Resources = value;
        }

        public IServiceDescriptionStatistics Statistics
        {
            get => new ServiceDescriptionStatistics(Obj.Statistics);
            set => Obj.Statistics = ((ServiceDescriptionStatistics)value).Obj;
        }

        public string Version
        {
            get => Obj.Version;
            set => Obj.Version = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IOrganizations GetOrganizationsFromOrganizationsRelation() => new Organizations(Obj.GetOrganizationsFromOrganizationsRelation());

        public async Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organizations> result = await Obj.GetOrganizationsFromOrganizationsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organizations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganizations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organizations> result = await Obj.GetOrganizationsFromOrganizationsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organizations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IOrganizations>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromLoginRelation() => Obj.GetStreamFromLoginRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync() => await Obj.GetStreamFromLoginRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLoginRelationAsync(cancellationToken);

		public Stream PostToLoginRelationForStream(Stream dataToSend) => Obj.PostToLoginRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(Stream dataToSend) => await Obj.PostToLoginRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToLoginRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromGuestLoginRelation() => Obj.GetStreamFromGuestLoginRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync() => await Obj.GetStreamFromGuestLoginRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromGuestLoginRelationAsync(cancellationToken);

		public Stream PostToGuestLoginRelationForStream(Stream dataToSend) => Obj.PostToGuestLoginRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(Stream dataToSend) => await Obj.PostToGuestLoginRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToGuestLoginRelationForStreamAsync(cancellationToken, dataToSend);

		public string GetStringFromWindowsLoginRelation() => Obj.GetStringFromWindowsLoginRelation();

		public async Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync() => await Obj.GetStringFromWindowsLoginRelationAsync();

		public async Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync(CancellationToken cancellationToken) => await Obj.GetStringFromWindowsLoginRelationAsync(cancellationToken);

		public string PostToWindowsLoginRelationForString(Stream dataToSend) => Obj.PostToWindowsLoginRelationForString(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(Stream dataToSend) => await Obj.PostToWindowsLoginRelationForStringAsync(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToWindowsLoginRelationForStringAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromChangePasswordRelation() => Obj.GetStreamFromChangePasswordRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync() => await Obj.GetStreamFromChangePasswordRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromChangePasswordRelationAsync(cancellationToken);

		public Stream PostToChangePasswordRelationForStream(Stream dataToSend) => Obj.PostToChangePasswordRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(Stream dataToSend) => await Obj.PostToChangePasswordRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToChangePasswordRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromResetPasswordRelation() => Obj.GetStreamFromResetPasswordRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync() => await Obj.GetStreamFromResetPasswordRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromResetPasswordRelationAsync(cancellationToken);

		public Stream PostToResetPasswordRelationForStream(Stream dataToSend) => Obj.PostToResetPasswordRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(Stream dataToSend) => await Obj.PostToResetPasswordRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToResetPasswordRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromTokenLoginRelation() => Obj.GetStreamFromTokenLoginRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync() => await Obj.GetStreamFromTokenLoginRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromTokenLoginRelationAsync(cancellationToken);

		public Stream PostToTokenLoginRelationForStream(Stream dataToSend) => Obj.PostToTokenLoginRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(Stream dataToSend) => await Obj.PostToTokenLoginRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToTokenLoginRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromTrustedLoginRelation() => Obj.GetStreamFromTrustedLoginRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync() => await Obj.GetStreamFromTrustedLoginRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromTrustedLoginRelationAsync(cancellationToken);

		public Stream PostToTrustedLoginRelationForStream(Stream dataToSend) => Obj.PostToTrustedLoginRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(Stream dataToSend) => await Obj.PostToTrustedLoginRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToTrustedLoginRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream PostToJwtLoginRelationForStream(Stream dataToSend) => Obj.PostToJwtLoginRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(Stream dataToSend) => await Obj.PostToJwtLoginRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToJwtLoginRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromLogoutRelation() => Obj.GetStreamFromLogoutRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync() => await Obj.GetStreamFromLogoutRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLogoutRelationAsync(cancellationToken);

		public Stream GetStreamFromDisconnectRelation() => Obj.GetStreamFromDisconnectRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync() => await Obj.GetStreamFromDisconnectRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDisconnectRelationAsync(cancellationToken);

		public string GetStringFromLoginCookieRelation() => Obj.GetStringFromLoginCookieRelation();

		public async Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync() => await Obj.GetStringFromLoginCookieRelationAsync();

		public async Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync(CancellationToken cancellationToken) => await Obj.GetStringFromLoginCookieRelationAsync(cancellationToken);

        public IAdhocRenderingFiles GetAdhocRenderingFilesFromAdhocRenderingRelation() => new AdhocRenderingFiles(Obj.GetAdhocRenderingFilesFromAdhocRenderingRelation());

        public async Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFiles> result = await Obj.GetAdhocRenderingFilesFromAdhocRenderingRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFiles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFiles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFiles> result = await Obj.GetAdhocRenderingFilesFromAdhocRenderingRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFiles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFiles>(temp).ConfigureAwait(false);
        }

        public IAdhocRenderingFile PostToAdhocRenderingRelationForAdhocRenderingFile(string requestedContentType, Stream dataToSend) => new AdhocRenderingFile(Obj.PostToAdhocRenderingRelationForAdhocRenderingFile(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.PostToAdhocRenderingRelationForAdhocRenderingFileAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.PostToAdhocRenderingRelationForAdhocRenderingFileAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromRootSchemaRelation() => Obj.GetStreamFromRootSchemaRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync() => await Obj.GetStreamFromRootSchemaRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromRootSchemaRelationAsync(cancellationToken);

		public string GetStringFromPermanentUrlRelation() => Obj.GetStringFromPermanentUrlRelation();

		public async Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync() => await Obj.GetStringFromPermanentUrlRelationAsync();

		public async Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync(CancellationToken cancellationToken) => await Obj.GetStringFromPermanentUrlRelationAsync(cancellationToken);

        public IIdentityServiceInfo GetIdentityServiceInfoFromIdentityServiceInfoRelation() => new IdentityServiceInfo(Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelation());

        public async Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.IdentityServiceInfo> result = await Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IdentityServiceInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IIdentityServiceInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.IdentityServiceInfo> result = await Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IdentityServiceInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IIdentityServiceInfo>(temp).ConfigureAwait(false);
        }
    }
}
