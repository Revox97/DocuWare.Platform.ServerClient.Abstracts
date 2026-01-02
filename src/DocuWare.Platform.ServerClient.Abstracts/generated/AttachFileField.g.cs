using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileField(SDK.AttachFileField obj) : IAttachFileField
    {
        internal SDK.AttachFileField Obj { get; } = obj;

        public List<IAttachFileInfo> AttachFileInfos
        {
            get => Obj.AttachFileInfos.Select(x => new AttachFileInfo(x) as IAttachFileInfo).ToList();
            set => Obj.AttachFileInfos = value.Select(x => ((AttachFileInfo)x).Obj).ToList();
        }
    }
}
