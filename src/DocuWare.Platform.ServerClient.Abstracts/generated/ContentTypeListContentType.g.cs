using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListContentType(DocuWare.Platform.ServerClient.ContentTypeListContentType obj) : IContentTypeListContentType
    {
        internal DocuWare.Platform.ServerClient.ContentTypeListContentType Obj { get; } = obj;

        public string IntroducedIn
        {
            get => Obj.IntroducedIn;
            set => Obj.IntroducedIn = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
