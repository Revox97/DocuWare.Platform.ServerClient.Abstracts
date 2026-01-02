using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileInfo(SDK.AttachFileInfo obj) : IAttachFileInfo
    {
        internal SDK.AttachFileInfo Obj { get; } = obj;
    }
}
