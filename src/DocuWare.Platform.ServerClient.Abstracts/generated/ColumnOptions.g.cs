using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnOptions(DocuWare.Platform.ServerClient.ColumnOptions obj) : IColumnOptions
    {
        internal DocuWare.Platform.ServerClient.ColumnOptions Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
