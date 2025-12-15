using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PartialDownloadExtensionBase(SDK.PartialDownloadExtensionBase obj) : IPartialDownloadExtensionBase
    {
        internal SDK.PartialDownloadExtensionBase Obj { get; } = obj;
    }
}
