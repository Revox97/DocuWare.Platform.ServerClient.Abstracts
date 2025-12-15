using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NullTableResultValue(SDK.NullTableResultValue obj) : INullTableResultValue
    {
        internal SDK.NullTableResultValue Obj { get; } = obj;
    }
}
