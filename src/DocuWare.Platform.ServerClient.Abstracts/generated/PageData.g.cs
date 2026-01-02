using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PageData(SDK.PageData obj) : IPageData
    {
        internal SDK.PageData Obj { get; } = obj;

        public IDWRectangle ContentArea
        {
            get => new DWRectangle(Obj.ContentArea);
            set => Obj.ContentArea = ((DWRectangle)value).Obj;
        }

        public int DpiX
        {
            get => Obj.DpiX;
            set => Obj.DpiX = value;
        }

        public int DpiY
        {
            get => Obj.DpiY;
            set => Obj.DpiY = value;
        }

        public int Width
        {
            get => Obj.Width;
            set => Obj.Width = value;
        }

        public int Height
        {
            get => Obj.Height;
            set => Obj.Height = value;
        }
    }
}
