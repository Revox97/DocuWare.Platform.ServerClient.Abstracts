using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateColumn(SDK.DateColumn obj) : IDateColumn
    {
        internal SDK.DateColumn Obj { get; } = obj;
    }
}
