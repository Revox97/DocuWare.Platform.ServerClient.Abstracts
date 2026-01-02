using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EagleAttribute(DocuWare.Platform.ServerClient.EagleAttribute obj) : IEagleAttribute
    {
        internal DocuWare.Platform.ServerClient.EagleAttribute Obj { get; } = obj;
    }
}
