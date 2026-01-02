using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnValue(DocuWare.Platform.ServerClient.ColumnValue obj) : IColumnValue
    {
        internal DocuWare.Platform.ServerClient.ColumnValue Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
