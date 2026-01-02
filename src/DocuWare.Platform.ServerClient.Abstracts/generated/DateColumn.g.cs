using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateColumn(DocuWare.Platform.ServerClient.DateColumn obj) : IDateColumn
    {
        internal DocuWare.Platform.ServerClient.DateColumn Obj { get; } = obj;
    }
}
