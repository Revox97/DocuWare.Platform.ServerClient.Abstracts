using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableColumnOptions(DocuWare.Platform.ServerClient.TableColumnOptions obj) : ITableColumnOptions
    {
        internal DocuWare.Platform.ServerClient.TableColumnOptions Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
