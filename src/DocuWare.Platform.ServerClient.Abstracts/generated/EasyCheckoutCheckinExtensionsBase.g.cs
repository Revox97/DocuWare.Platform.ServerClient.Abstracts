using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyCheckoutCheckinExtensionsBase(DocuWare.Platform.ServerClient.EasyCheckoutCheckinExtensionsBase obj) : IEasyCheckoutCheckinExtensionsBase
    {
        internal DocuWare.Platform.ServerClient.EasyCheckoutCheckinExtensionsBase Obj { get; } = obj;
    }
}
