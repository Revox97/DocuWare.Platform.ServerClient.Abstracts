using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PagesBlockQuery(DocuWare.Platform.ServerClient.PagesBlockQuery obj) : IPagesBlockQuery
    {
        internal DocuWare.Platform.ServerClient.PagesBlockQuery Obj { get; } = obj;

        public int FirstPage
        {
            get => Obj.FirstPage;
            set => Obj.FirstPage = value;
        }

        public int PageCount
        {
            get => Obj.PageCount;
            set => Obj.PageCount = value;
        }
    }
}
