using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextZone(DocuWare.Platform.ServerClient.Content.TextZone obj) : ITextZone
    {
        internal DocuWare.Platform.ServerClient.Content.TextZone Obj { get; } = obj;

        public List<ILine> Ln
        {
            get => Obj.Ln.Select(x => new Line(x) as ILine).ToList();
            set => Obj.Ln = value.Select(x => ((Line)x).Obj).ToList();
        }

        public string Lang
        {
            get => Obj.Lang;
            set => Obj.Lang = value;
        }

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
