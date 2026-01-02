using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DWSize(DocuWare.Platform.ServerClient.DWSize obj) : IDWSize
    {
        internal DocuWare.Platform.ServerClient.DWSize Obj { get; } = obj;

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
