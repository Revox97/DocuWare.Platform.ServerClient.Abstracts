using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Line(DocuWare.Platform.ServerClient.Content.Line obj) : ILine
    {
        internal DocuWare.Platform.ServerClient.Content.Line Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }

        public bool bold
        {
            get => Obj.bold;
            set => Obj.bold = value;
        }

        public int fontSize
        {
            get => Obj.fontSize;
            set => Obj.fontSize = value;
        }

        public int BaseLine
        {
            get => Obj.BaseLine;
            set => Obj.BaseLine = value;
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
