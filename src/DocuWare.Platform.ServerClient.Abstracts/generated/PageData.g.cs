using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PageData(DocuWare.Platform.ServerClient.PageData obj) : IPageData
    {
        internal DocuWare.Platform.ServerClient.PageData Obj { get; } = obj;

        public int LowQualitySize
        {
            get => Obj.LowQualitySize;
            set => Obj.LowQualitySize = value;
        }

        public int TileSize
        {
            get => Obj.TileSize;
            set => Obj.TileSize = value;
        }

        public PlatformImageFormat RenderedImageFormat
        {
            get => (PlatformImageFormat)Obj.RenderedImageFormat;
            set => Obj.RenderedImageFormat = (DocuWare.Platform.ServerClient.PlatformImageFormat)value;
        }

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
