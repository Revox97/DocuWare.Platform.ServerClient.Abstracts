using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListSchemaType(SDK.ContentTypeListSchemaType obj) : IContentTypeListSchemaType
    {
        internal SDK.ContentTypeListSchemaType Obj { get; } = obj;

        public string IntroducedIn
        {
            get => Obj.IntroducedIn;
            set => Obj.IntroducedIn = value;
        }

        public XmlQualifiedName Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
