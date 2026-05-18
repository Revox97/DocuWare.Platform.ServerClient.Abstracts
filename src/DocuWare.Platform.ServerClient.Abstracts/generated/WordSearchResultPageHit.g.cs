using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WordSearchResultPageHit(SDK.WordSearchResultPageHit obj) : IWordSearchResultPageHit
    {
        internal SDK.WordSearchResultPageHit Obj { get; } = obj;

        public List<IWordSearchResultWordHit> Hits
        {
            get => Obj.Hits.Select(x => new WordSearchResultWordHit(x) as IWordSearchResultWordHit).ToList();
            set => Obj.Hits = value.Select(x => ((WordSearchResultWordHit)x).Obj).ToList();
        }

        public int PageNum
        {
            get => Obj.PageNum;
            set => Obj.PageNum = value;
        }
    }
}
