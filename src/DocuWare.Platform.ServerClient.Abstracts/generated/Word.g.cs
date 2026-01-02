using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Word(SDK.Word obj) : IWord
    {
        internal SDK.Word Obj { get; } = obj;

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

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
