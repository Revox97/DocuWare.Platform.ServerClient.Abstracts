using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileInfo(DocuWare.Platform.ServerClient.AttachFileInfo obj) : IAttachFileInfo
    {
        internal DocuWare.Platform.ServerClient.AttachFileInfo Obj { get; } = obj;

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

        public FileSource Source
        {
            get => (FileSource)Obj.Source;
            set => Obj.Source = (DocuWare.Platform.ServerClient.FileSource)value;
        }
    }
}
