using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileNameExtensions(SDK.FileNameExtensions obj) : IFileNameExtensions
    {
        internal SDK.FileNameExtensions Obj { get; } = obj;
    }
}
