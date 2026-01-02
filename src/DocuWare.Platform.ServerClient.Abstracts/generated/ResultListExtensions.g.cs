using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultListExtensions(DocuWare.Platform.ServerClient.ResultListExtensions obj) : IResultListExtensions
    {
        internal DocuWare.Platform.ServerClient.ResultListExtensions Obj { get; } = obj;
    }
}
