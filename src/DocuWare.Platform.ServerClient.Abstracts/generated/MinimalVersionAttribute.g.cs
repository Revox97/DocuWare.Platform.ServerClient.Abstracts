using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MinimalVersionAttribute(DocuWare.Platform.ServerClient.MinimalVersionAttribute obj) : IMinimalVersionAttribute
    {
        internal DocuWare.Platform.ServerClient.MinimalVersionAttribute Obj { get; } = obj;
    }
}
