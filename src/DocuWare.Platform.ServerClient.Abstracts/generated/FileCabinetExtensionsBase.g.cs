using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetExtensionsBase(SDK.FileCabinetExtensionsBase obj) : IFileCabinetExtensionsBase
    {
        internal SDK.FileCabinetExtensionsBase Obj { get; } = obj;
    }
}
