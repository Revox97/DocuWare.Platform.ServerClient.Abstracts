using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DWSize(SDK.DWSize obj) : IDWSize
    {
        internal SDK.DWSize Obj { get; } = obj;

        public double Width
        {
            get => Obj.Width;
            set => Obj.Width = value;
        }

        public double Height
        {
            get => Obj.Height;
            set => Obj.Height = value;
        }
    }
}
