using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileField(DocuWare.Platform.ServerClient.AttachFileField obj) : IAttachFileField
    {
        internal DocuWare.Platform.ServerClient.AttachFileField Obj { get; } = obj;

        public List<IAttachFileInfo> AttachFileInfos
        {
            get => Obj.AttachFileInfos.Select(x => new AttachFileInfo(x) as IAttachFileInfo).ToList();
            set => Obj.AttachFileInfos = value.Select(x => ((AttachFileInfo)x).Obj).ToList();
        }
    }
}
