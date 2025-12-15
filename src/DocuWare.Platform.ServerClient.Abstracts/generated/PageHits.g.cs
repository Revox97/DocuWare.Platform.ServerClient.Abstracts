using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PageHits(SDK.PageHits obj) : IPageHits
    {
        internal SDK.PageHits Obj { get; } = obj;

        public List<IWordSearchResultPageHit> PageHit
        {
            get => Obj.PageHit.Select(x => new WordSearchResultPageHit(x) as IWordSearchResultPageHit).ToList();
            set => Obj.PageHit = value.Select(x => ((WordSearchResultPageHit)x).Obj).ToList();
        }
    }
}
