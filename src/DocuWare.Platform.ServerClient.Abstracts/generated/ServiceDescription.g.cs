using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescription(SDK.ServiceDescription obj) : IServiceDescription
    {
        internal SDK.ServiceDescription Obj { get; } = obj;

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

        public string OrganizationsRelationLink => Obj.OrganizationsRelationLink;

        public string LoginRelationLink => Obj.LoginRelationLink;

        public string GuestLoginRelationLink => Obj.GuestLoginRelationLink;

        public string WindowsLoginRelationLink => Obj.WindowsLoginRelationLink;

        public string ChangePasswordRelationLink => Obj.ChangePasswordRelationLink;

        public string ResetPasswordRelationLink => Obj.ResetPasswordRelationLink;

        public string TokenLoginRelationLink => Obj.TokenLoginRelationLink;

        public string TrustedLoginRelationLink => Obj.TrustedLoginRelationLink;

        public string JwtLoginRelationLink => Obj.JwtLoginRelationLink;

        public string LogoutRelationLink => Obj.LogoutRelationLink;

        public string DisconnectRelationLink => Obj.DisconnectRelationLink;

        public string LoginCookieRelationLink => Obj.LoginCookieRelationLink;

        public string UriTemplatesRelationLink => Obj.UriTemplatesRelationLink;

        public string AdhocRenderingRelationLink => Obj.AdhocRenderingRelationLink;

        public string RootSchemaRelationLink => Obj.RootSchemaRelationLink;

        public string LogRelationLink => Obj.LogRelationLink;

        public string PermanentUrlRelationLink => Obj.PermanentUrlRelationLink;

        public string IdentityServiceInfoRelationLink => Obj.IdentityServiceInfoRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Organizations GetOrganizationsFromOrganizationsRelation() => new Organizations(Obj.GetOrganizationsFromOrganizationsRelation());

        public async Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organizations> result = await Obj.GetOrganizationsFromOrganizationsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organizations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Organizations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IOrganizations>> GetOrganizationsFromOrganizationsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Organizations> result = await Obj.GetOrganizationsFromOrganizationsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Organizations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Organizations>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromLoginRelation() => Obj.GetStreamFromLoginRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLoginRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLoginRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLoginRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToLoginRelationForStream(Stream dataToSend) => Obj.PostToLoginRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToLoginRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToLoginRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromGuestLoginRelation() => Obj.GetStreamFromGuestLoginRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromGuestLoginRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromGuestLoginRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromGuestLoginRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToGuestLoginRelationForStream(Stream dataToSend) => Obj.PostToGuestLoginRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToGuestLoginRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToGuestLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToGuestLoginRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string GetStringFromWindowsLoginRelation() => Obj.GetStringFromWindowsLoginRelation();

        public async Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromWindowsLoginRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromWindowsLoginRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromWindowsLoginRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async string PostToWindowsLoginRelationForString(Stream dataToSend) => Obj.PostToWindowsLoginRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToWindowsLoginRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToWindowsLoginRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToWindowsLoginRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromChangePasswordRelation() => Obj.GetStreamFromChangePasswordRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromChangePasswordRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromChangePasswordRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromChangePasswordRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToChangePasswordRelationForStream(Stream dataToSend) => Obj.PostToChangePasswordRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToChangePasswordRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToChangePasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToChangePasswordRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromResetPasswordRelation() => Obj.GetStreamFromResetPasswordRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromResetPasswordRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResetPasswordRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromResetPasswordRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToResetPasswordRelationForStream(Stream dataToSend) => Obj.PostToResetPasswordRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToResetPasswordRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToResetPasswordRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToResetPasswordRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromTokenLoginRelation() => Obj.GetStreamFromTokenLoginRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTokenLoginRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTokenLoginRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTokenLoginRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToTokenLoginRelationForStream(Stream dataToSend) => Obj.PostToTokenLoginRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTokenLoginRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToTokenLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTokenLoginRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromTrustedLoginRelation() => Obj.GetStreamFromTrustedLoginRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTrustedLoginRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTrustedLoginRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTrustedLoginRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToTrustedLoginRelationForStream(Stream dataToSend) => Obj.PostToTrustedLoginRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTrustedLoginRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToTrustedLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTrustedLoginRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToJwtLoginRelationForStream(Stream dataToSend) => Obj.PostToJwtLoginRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToJwtLoginRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToJwtLoginRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToJwtLoginRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromLogoutRelation() => Obj.GetStreamFromLogoutRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLogoutRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLogoutRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLogoutRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromDisconnectRelation() => Obj.GetStreamFromDisconnectRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDisconnectRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDisconnectRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDisconnectRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string GetStringFromLoginCookieRelation() => Obj.GetStringFromLoginCookieRelation();

        public async Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromLoginCookieRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromLoginCookieRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromLoginCookieRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public AdhocRenderingFiles GetAdhocRenderingFilesFromAdhocRenderingRelation() => new AdhocRenderingFiles(Obj.GetAdhocRenderingFilesFromAdhocRenderingRelation());

        public async Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFiles> result = await Obj.GetAdhocRenderingFilesFromAdhocRenderingRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFiles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AdhocRenderingFiles>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFiles>> GetAdhocRenderingFilesFromAdhocRenderingRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFiles> result = await Obj.GetAdhocRenderingFilesFromAdhocRenderingRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFiles(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AdhocRenderingFiles>(temp).ConfigureAwait(false);
        }

        public AdhocRenderingFile PostToAdhocRenderingRelationForAdhocRenderingFile(string requestedContentType, Stream dataToSend) => new AdhocRenderingFile(Obj.PostToAdhocRenderingRelationForAdhocRenderingFile(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.PostToAdhocRenderingRelationForAdhocRenderingFileAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AdhocRenderingFile>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> PostToAdhocRenderingRelationForAdhocRenderingFileAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.PostToAdhocRenderingRelationForAdhocRenderingFileAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<AdhocRenderingFile>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromRootSchemaRelation() => Obj.GetStreamFromRootSchemaRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromRootSchemaRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromRootSchemaRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromRootSchemaRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string GetStringFromPermanentUrlRelation() => Obj.GetStringFromPermanentUrlRelation();

        public async Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromPermanentUrlRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromPermanentUrlRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromPermanentUrlRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IdentityServiceInfo GetIdentityServiceInfoFromIdentityServiceInfoRelation() => new IdentityServiceInfo(Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelation());

        public async Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.IdentityServiceInfo> result = await Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IdentityServiceInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IdentityServiceInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IIdentityServiceInfo>> GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.IdentityServiceInfo> result = await Obj.GetIdentityServiceInfoFromIdentityServiceInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IdentityServiceInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IdentityServiceInfo>(temp).ConfigureAwait(false);
        }
    }
}
