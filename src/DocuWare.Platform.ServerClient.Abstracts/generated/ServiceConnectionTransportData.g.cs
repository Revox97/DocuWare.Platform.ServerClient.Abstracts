using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTransportData(DocuWare.Platform.ServerClient.ServiceConnectionTransportData obj) : IServiceConnectionTransportData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionTransportData Obj { get; } = obj;

        public ProductInfoHeaderValue[] UserAgent
        {
            get => Obj.UserAgent;
            set => Obj.UserAgent = value;
        }

        public HttpMessageHandler HttpClientHandler
        {
            get => Obj.HttpClientHandler;
            set => Obj.HttpClientHandler = value;
        }

        public StringWithQualityHeaderValue[] AcceptLanguage
        {
            get => Obj.AcceptLanguage;
            set => Obj.AcceptLanguage = value;
        }

        public CancellationToken CancellationToken
        {
            get => Obj.CancellationToken;
            set => Obj.CancellationToken = value;
        }
    }
}
