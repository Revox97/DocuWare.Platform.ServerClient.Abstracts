using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WordSearchResultWordHit(DocuWare.Platform.ServerClient.WordSearchResultWordHit obj) : IWordSearchResultWordHit
    {
        internal DocuWare.Platform.ServerClient.WordSearchResultWordHit Obj { get; } = obj;

        public int L
        {
            get => Obj.L;
            set => Obj.L = value;
        }

        public int T
        {
            get => Obj.T;
            set => Obj.T = value;
        }

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }

        public int H
        {
            get => Obj.H;
            set => Obj.H = value;
        }
    }
}
