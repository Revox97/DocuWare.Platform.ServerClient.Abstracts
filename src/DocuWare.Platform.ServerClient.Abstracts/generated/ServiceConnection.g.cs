using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnection(SDK.ServiceConnection obj) : IServiceConnection
    {
        internal SDK.ServiceConnection Obj { get; } = obj;

		public HttpClient HttpClient => Obj.HttpClient;

		public HttpClientProxy Proxy => Obj.Proxy;

		public IServiceDescription ServiceDescription => new ServiceDescription(Obj.ServiceDescription);

		public IOrganization[] Organizations => new Organization[](Obj.Organizations);

		public Task<IOrganization[]> OrganizationsAsync => Obj.OrganizationsAsync;

		public async void ReplaceHttpClient(IServiceConnection otherServiceConnection) => Obj.ReplaceHttpClient(otherServiceConnection);
		public async void ReplaceHttpClient(HttpClient httpClient) => Obj.ReplaceHttpClient(httpClient);
		public async void Disconnect() => Obj.Disconnect();
		public async Task DisconnectAsync() => await Obj.DisconnectAsync();
		public async Task DisconnectAsync(CancellationToken token) => await Obj.DisconnectAsync(token);
		public async Task<IOrganization[]> GetOrganizationsAsync() => await Obj.GetOrganizationsAsync();
        public T GetXml(string uri) => new (Obj.GetXml(uri));

        public async Task<DeserializedHttpResponse<T>> GetXmlAsync(string uri)
        {
            DocuWare.Platform.ServerClient.T result = await Obj.GetXmlAsync(uri).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new T(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<T>(temp).ConfigureAwait(false);
        }

    }
}
