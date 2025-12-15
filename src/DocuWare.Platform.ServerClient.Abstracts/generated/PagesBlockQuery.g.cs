using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PagesBlockQuery(SDK.PagesBlockQuery obj) : IPagesBlockQuery
    {
        internal SDK.PagesBlockQuery Obj { get; } = obj;

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
