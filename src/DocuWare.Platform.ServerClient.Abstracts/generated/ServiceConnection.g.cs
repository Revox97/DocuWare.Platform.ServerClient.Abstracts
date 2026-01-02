using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnection(DocuWare.Platform.ServerClient.ServiceConnection obj) : IServiceConnection
    {
        internal DocuWare.Platform.ServerClient.ServiceConnection Obj { get; } = obj;

		public void ReplaceHttpClient(IServiceConnection otherServiceConnection) => Obj.ReplaceHttpClient(((ServiceConnection)otherServiceConnection).Obj);

		public void ReplaceHttpClient(HttpClient httpClient) => Obj.ReplaceHttpClient(httpClient);

		public void Disconnect() => Obj.Disconnect();

		public async Task DisconnectAsync() => await Obj.DisconnectAsync();

		public async Task DisconnectAsync(CancellationToken token) => await Obj.DisconnectAsync(token);

		public async Task<IOrganization[]> GetOrganizationsAsync() => await Obj.GetOrganizationsAsync();

        public T GetXml<T, IT>(string uri) => Obj.GetXml<typeof(IT)>(uri) as T;

        public async Task<DeserializedHttpResponse<T>> GetXmlAsync(string uri)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.T> result = await Obj.GetXmlAsync(uri).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new T(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IT>(temp).ConfigureAwait(false);
        }
    }
}
