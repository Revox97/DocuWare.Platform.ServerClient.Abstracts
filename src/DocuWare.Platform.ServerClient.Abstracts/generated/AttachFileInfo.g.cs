using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileInfo(SDK.AttachFileInfo obj) : IAttachFileInfo
    {
        internal SDK.AttachFileInfo Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string FormattedSize
        {
            get => Obj.FormattedSize;
            set => Obj.FormattedSize = value;
        }

        public DocuWare.Platform.ServerClient.FileSource Source
        {
            get => Obj.Source;
            set => Obj.Source = value;
        }
    }
}
