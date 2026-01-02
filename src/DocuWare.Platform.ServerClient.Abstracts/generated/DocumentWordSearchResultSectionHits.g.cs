using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentWordSearchResultSectionHits(DocuWare.Platform.ServerClient.DocumentWordSearchResultSectionHits obj) : IDocumentWordSearchResultSectionHits
    {
        internal DocuWare.Platform.ServerClient.DocumentWordSearchResultSectionHits Obj { get; } = obj;

        public List<IWordSearchResultPageHit> PageHits
        {
            get => Obj.PageHits.Select(x => new WordSearchResultPageHit(x) as IWordSearchResultPageHit).ToList();
            set => Obj.PageHits = value.Select(x => ((WordSearchResultPageHit)x).Obj).ToList();
        }

        public string SectionId
        {
            get => Obj.SectionId;
            set => Obj.SectionId = value;
        }
    }
}
