using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateTableColumnOptions(SDK.DateTableColumnOptions obj) : IDateTableColumnOptions
    {
        internal SDK.DateTableColumnOptions Obj { get; } = obj;
    }
}
