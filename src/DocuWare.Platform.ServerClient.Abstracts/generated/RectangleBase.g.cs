using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RectangleBase(DocuWare.Platform.ServerClient.Content.RectangleBase obj) : IRectangleBase
    {
        internal DocuWare.Platform.ServerClient.Content.RectangleBase Obj { get; } = obj;

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
