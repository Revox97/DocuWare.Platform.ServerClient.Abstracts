using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NullTableResultValue(DocuWare.Platform.ServerClient.NullTableResultValue obj) : INullTableResultValue
    {
        internal DocuWare.Platform.ServerClient.NullTableResultValue Obj { get; } = obj;
    }
}
