using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListSchemaType(DocuWare.Platform.ServerClient.ContentTypeListSchemaType obj) : IContentTypeListSchemaType
    {
        internal DocuWare.Platform.ServerClient.ContentTypeListSchemaType Obj { get; } = obj;

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
