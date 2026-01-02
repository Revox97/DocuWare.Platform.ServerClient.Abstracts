using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HawkAttribute(DocuWare.Platform.ServerClient.HawkAttribute obj) : IHawkAttribute
    {
        internal DocuWare.Platform.ServerClient.HawkAttribute Obj { get; } = obj;
    }
}
