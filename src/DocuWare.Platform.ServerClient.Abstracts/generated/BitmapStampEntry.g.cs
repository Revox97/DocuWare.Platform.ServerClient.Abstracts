using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BitmapStampEntry(DocuWare.Platform.ServerClient.BitmapStampEntry obj) : IBitmapStampEntry
    {
        internal DocuWare.Platform.ServerClient.BitmapStampEntry Obj { get; } = obj;

        public Byte[] PngData
        {
            get => Obj.PngData;
            set => Obj.PngData = value;
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

        public DocuWare.Platform.ServerClient.StampSignatureType Signature
        {
            get => Obj.Signature;
            set => Obj.Signature = value;
        }

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public bool Visible
        {
            get => Obj.Visible;
            set => Obj.Visible = value;
        }

        public bool Frame
        {
            get => Obj.Frame;
            set => Obj.Frame = value;
        }

        public bool ShowUser
        {
            get => Obj.ShowUser;
            set => Obj.ShowUser = value;
        }

        public bool ShowDate
        {
            get => Obj.ShowDate;
            set => Obj.ShowDate = value;
        }

        public bool ShowTime
        {
            get => Obj.ShowTime;
            set => Obj.ShowTime = value;
        }

        public string SigScopeInfo
        {
            get => Obj.SigScopeInfo;
            set => Obj.SigScopeInfo = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

        public int Rotation
        {
            get => Obj.Rotation;
            set => Obj.Rotation = value;
        }

        public bool Transparent
        {
            get => Obj.Transparent;
            set => Obj.Transparent = value;
        }

        public int StrokeWidth
        {
            get => Obj.StrokeWidth;
            set => Obj.StrokeWidth = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
