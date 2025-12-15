using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultListExtensions(SDK.ResultListExtensions obj) : IResultListExtensions
    {
        internal SDK.ResultListExtensions Obj { get; } = obj;
    }
}
