using SDK = DocuWare.Platform.ServerClient;

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
