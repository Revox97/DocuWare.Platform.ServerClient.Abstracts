using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AutoNumberField(SDK.AutoNumberField obj) : IAutoNumberField
    {
        internal SDK.AutoNumberField Obj { get; } = obj;
    }
}
