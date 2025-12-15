using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyFileUploadExtensionsBase(SDK.EasyFileUploadExtensionsBase obj) : IEasyFileUploadExtensionsBase
    {
        internal SDK.EasyFileUploadExtensionsBase Obj { get; } = obj;
    }
}
