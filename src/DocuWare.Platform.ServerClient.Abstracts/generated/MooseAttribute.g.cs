using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MooseAttribute(DocuWare.Platform.ServerClient.MooseAttribute obj) : IMooseAttribute
    {
        internal DocuWare.Platform.ServerClient.MooseAttribute Obj { get; } = obj;
    }
}
