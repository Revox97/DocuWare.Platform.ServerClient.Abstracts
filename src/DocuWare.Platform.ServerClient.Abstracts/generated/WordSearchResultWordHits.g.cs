using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WordSearchResultWordHits(SDK.WordSearchResultWordHits obj) : IWordSearchResultWordHits
    {
        internal SDK.WordSearchResultWordHits Obj { get; } = obj;

        public List<IWordSearchResultWordHit> Wd
        {
            get => Obj.Wd.Select(x => new WordSearchResultWordHit(x) as IWordSearchResultWordHit).ToList();
            set => Obj.Wd = value.Select(x => ((WordSearchResultWordHit)x).Obj).ToList();
        }
    }
}
