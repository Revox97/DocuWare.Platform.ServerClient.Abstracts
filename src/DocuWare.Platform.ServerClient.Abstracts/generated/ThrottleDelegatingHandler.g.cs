using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ThrottleDelegatingHandler(DocuWare.Platform.ServerClient.ThrottleDelegatingHandler obj) : IThrottleDelegatingHandler
    {
        internal DocuWare.Platform.ServerClient.ThrottleDelegatingHandler Obj { get; } = obj;

        public HttpMessageHandler InnerHandler
        {
            get => Obj.InnerHandler;
            set => Obj.InnerHandler = value;
        }
    }
}
