using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormProperties(SDK.FormProperties obj) : IFormProperties
    {
        internal SDK.FormProperties Obj { get; } = obj;
    }
}
