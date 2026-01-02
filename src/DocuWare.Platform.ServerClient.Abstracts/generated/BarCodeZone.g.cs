using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BarCodeZone(DocuWare.Platform.ServerClient.Content.BarCodeZone obj) : IBarCodeZone
    {
        internal DocuWare.Platform.ServerClient.Content.BarCodeZone Obj { get; } = obj;

        public string BarcodeType
        {
            get => Obj.BarcodeType;
            set => Obj.BarcodeType = value;
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
