using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
