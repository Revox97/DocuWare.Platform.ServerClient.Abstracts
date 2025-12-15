using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutCheckinExtensionsBase(SDK.EasyCheckoutCheckinExtensionsBase obj) : IEasyCheckoutCheckinExtensionsBase
    {
        internal SDK.EasyCheckoutCheckinExtensionsBase Obj { get; } = obj;
    }
}
