using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListFilter(SDK.SelectListFilter obj) : ISelectListFilter
    {
        internal SDK.SelectListFilter Obj { get; } = obj;
    }
}
