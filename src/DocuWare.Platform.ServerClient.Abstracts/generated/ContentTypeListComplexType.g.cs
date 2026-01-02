using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListComplexType(DocuWare.Platform.ServerClient.ContentTypeListComplexType obj) : IContentTypeListComplexType
    {
        internal DocuWare.Platform.ServerClient.ContentTypeListComplexType Obj { get; } = obj;

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
