using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateTableColumnOptions(DocuWare.Platform.ServerClient.DateTableColumnOptions obj) : IDateTableColumnOptions
    {
        internal DocuWare.Platform.ServerClient.DateTableColumnOptions Obj { get; } = obj;
    }
}
