using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DolphinAttribute(DocuWare.Platform.ServerClient.DolphinAttribute obj) : IDolphinAttribute
    {
        internal DocuWare.Platform.ServerClient.DolphinAttribute Obj { get; } = obj;
    }
}
