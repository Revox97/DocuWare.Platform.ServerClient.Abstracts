using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ThrottleDelegatingHandler(SDK.ThrottleDelegatingHandler obj) : IThrottleDelegatingHandler
    {
        internal SDK.ThrottleDelegatingHandler Obj { get; } = obj;

        public HttpMessageHandler InnerHandler
        {
            get => Obj.InnerHandler;
            set => Obj.InnerHandler = value;
        }
    }
}
