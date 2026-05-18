using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListComplexType(SDK.ContentTypeListComplexType obj) : IContentTypeListComplexType
    {
        internal SDK.ContentTypeListComplexType Obj { get; } = obj;

        public XElementWrapper Any
        {
            get => Obj.Any;
            set => Obj.Any = value;
        }

        public string IntroducedIn
        {
            get => Obj.IntroducedIn;
            set => Obj.IntroducedIn = value;
        }
    }
}
