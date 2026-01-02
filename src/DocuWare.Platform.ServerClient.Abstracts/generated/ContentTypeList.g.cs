using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeList(DocuWare.Platform.ServerClient.ContentTypeList obj) : IContentTypeList
    {
        internal DocuWare.Platform.ServerClient.ContentTypeList Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }

        public string IntroducedIn
        {
            get => Obj.IntroducedIn;
            set => Obj.IntroducedIn = value;
        }
    }
}
