using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImpalaAttribute(DocuWare.Platform.ServerClient.ImpalaAttribute obj) : IImpalaAttribute
    {
        internal DocuWare.Platform.ServerClient.ImpalaAttribute Obj { get; } = obj;
    }
}
