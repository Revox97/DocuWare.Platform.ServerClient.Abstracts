using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileInfo(DocuWare.Platform.ServerClient.AttachFileInfo obj) : IAttachFileInfo
    {
        internal DocuWare.Platform.ServerClient.AttachFileInfo Obj { get; } = obj;
    }
}
