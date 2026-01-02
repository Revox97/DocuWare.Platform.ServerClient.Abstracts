using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SearchPositionQuery(DocuWare.Platform.ServerClient.SearchPositionQuery obj) : ISearchPositionQuery
    {
        internal DocuWare.Platform.ServerClient.SearchPositionQuery Obj { get; } = obj;

        public bool IgnoreCase
        {
            get => Obj.IgnoreCase;
            set => Obj.IgnoreCase = value;
        }

        public bool WholeWord
        {
            get => Obj.WholeWord;
            set => Obj.WholeWord = value;
        }

        public int StartPage
        {
            get => Obj.StartPage;
            set => Obj.StartPage = value;
        }

        public int StartSectionNumber
        {
            get => Obj.StartSectionNumber;
            set => Obj.StartSectionNumber = value;
        }

        public int PageCount
        {
            get => Obj.PageCount;
            set => Obj.PageCount = value;
        }

        public bool Backward
        {
            get => Obj.Backward;
            set => Obj.Backward = value;
        }

        public bool RangeSearch
        {
            get => Obj.RangeSearch;
            set => Obj.RangeSearch = value;
        }

        public bool Normalize
        {
            get => Obj.Normalize;
            set => Obj.Normalize = value;
        }
    }
}
